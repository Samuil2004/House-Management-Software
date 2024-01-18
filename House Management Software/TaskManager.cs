using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace House_Management_Software
{
    public class TaskManager
    {
        private List<User> Users;
        DataManager dataManager;
        SqlDatabase sqlDatabase;
        User loggedInUser;
        public TaskManager(User loggedInUser)
        {
            dataManager = new DataManager();
            this.Users = dataManager.GetUsers();
            SortUsers();
            sqlDatabase = new SqlDatabase();
            this.loggedInUser = loggedInUser;
        }
        public TaskManager()
        {
            dataManager = new DataManager();
            this.Users = dataManager.GetUsers();
            SortUsers();
            sqlDatabase = new SqlDatabase();
        }
        public void SortUsers()
        {
            Users = Users.Where(user => user.Status != "admin").ToList();
        }
       
        public User RandomUser(DateTime date, string taskCategoryToExclude, User current_user)
        {
            taskCategories taskChosen = (taskCategories)Enum.Parse(typeof(taskCategories), taskCategoryToExclude);
            List<User> AllUsers = new List<User>(Users);
            List<User> availableUsers = AllUsers.Where(user => user.ApartmentNumber == current_user.ApartmentNumber).ToList();

            foreach (Task task in sqlDatabase.AllTasksSql(current_user))
            {
                if (task.GetDate == date && availableUsers.Contains(task.GetUser))
                {
                    availableUsers.Remove(task.GetUser);
                    if (task.GetCategory == taskChosen)
                    {
                        availableUsers.Remove(task.GetUser);
                    }
                }
            }
            if (availableUsers.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, availableUsers.Count);
                return availableUsers[randomIndex];
            }
            return null;
        }

        public string CreateATask(string newTaskCategory, string description, DateTime dateTime, bool isCompleted, User user)
        {
            taskCategories taskChosen = (taskCategories)Enum.Parse(typeof(taskCategories), newTaskCategory);
            foreach (Task task in GetAllTasks(loggedInUser))
            {
                if (task.GetUser == user && task.GetCategory == taskChosen && task.GetDate == dateTime)
                {
                    return $"{user} is already busy this day";
                }
            }
            Task newTask = new Task(sqlDatabase.GetTheHighestIdForTask()+1,taskChosen, description, dateTime, isCompleted, user, user.ApartmentNumber);
            sqlDatabase.InsertNewTaskToSql(newTask);
            return null;
        }


        public IEnumerable<Task> CheckerForSamePeopleTasksDates(string newTaskCategory, DateTime dateTime)
        {
            taskCategories taskChosen = (taskCategories)Enum.Parse(typeof(taskCategories), newTaskCategory);
            IEnumerable<Task> existingTasksForCategory = GetAllTasks(loggedInUser).Where(task => task.GetCategory == taskChosen && task.GetDate == dateTime);
            return existingTasksForCategory;
        }

        public List<Task> GetAllTasks(User loggedInUser)
        {
            return sqlDatabase.AllTasksSql(loggedInUser);
        }

        public void DeleteTask(string taskInfo, string dayOfTheWeek)
        {
            Task selectedTask = (GetAllTasks(loggedInUser)).FirstOrDefault(task => task.TaskForCalendar == taskInfo && task.DayOfWeek.Equals(dayOfTheWeek));
            if (selectedTask.GetUser.Equals(loggedInUser.Email))
            {
                if (selectedTask.GetStatus)
                {
                    sqlDatabase.DeleteATask(selectedTask);
                }
                else
                {
                    MessageBox.Show("This task is not completed yet");
                }
            }
            else
            {
                MessageBox.Show("You can not delete other's tasks");
            }
        }

        public bool TaskCompleted(User loggedInUser, string taskInfo, string dayOfTheWeek)
        {
            Task selectedTask = (GetAllTasks(loggedInUser)).FirstOrDefault(task => task.TaskForCalendar == taskInfo && task.DayOfWeek.Equals(dayOfTheWeek));
            if (selectedTask.GetUser.Email.Equals(loggedInUser.Email))
            {
                selectedTask.ChangeStatus();
                sqlDatabase.ChangeStatusTaskSql(selectedTask);
                return true;
            }
            return false;
        }

        public string GetTaskDescription(string taskInfo, string dayOfTheWeek)
        {
            Task selectedTask = (GetAllTasks(loggedInUser)).FirstOrDefault(task => task.TaskForCalendar == taskInfo && task.DayOfWeek.Equals(dayOfTheWeek));
            return selectedTask.TaskDescription;
        }      

        public List<Task> GetAllTasksForAdmin()
        {
            return sqlDatabase.AllTasksAdminSql();
        }

        public void TaskCompletedAdmin(Task task)
        {
            sqlDatabase.ChangeStatusTaskSql(task);
        }

        public void CreateExpenses()
        {
            DateTime dateTimeNow = DateTime.Today;
            //DateTime dateNextFriday = dateTimeNow.AddDays(4);
            if(DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                if (!GetAllTasks(loggedInUser).Any(task => dateTimeNow.AddDays(4).DayOfWeek == DayOfWeek.Friday && task.GetCategory.Equals(taskCategories.Expenses)))
                {
                    foreach (User user in Users.Where(user => user.Status.Equals(loggedInUser.Status)))
                    {
                        CreateATask("Expenses", "Please give the money for the apartment budget", dateTimeNow.AddDays(4), false, user);
                    }
                }
            }
        }
    }
}
