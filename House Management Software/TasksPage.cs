using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Management_Software
{
    public partial class TasksPage : Form
    {
        TaskManager taskManager;
        User loggedInUser;
        MenuPage menuPage;
        private bool close_application;
        public TasksPage(MenuPage menuPage, User loggedInUser)
        {
            this.loggedInUser = loggedInUser;
            taskManager = new TaskManager(loggedInUser);
            this.menuPage = menuPage;
            InitializeComponent();
            DeleteTaskButton.Enabled = false;
            cbChooseInformation.Items.Add("All tasks");
            foreach (taskCategories taskCategory in Enum.GetValues(typeof(taskCategories)))
            {
                cbChooseInformation.Items.Add(taskCategory);
            }
            cbChooseInformation.SelectedItem = "All tasks";
            taskManager.CreateExpenses();
            RefreshPage();
            if (taskManager.GetAllTasks(loggedInUser).Count > 0)
            {
                DeleteTaskButton.Enabled = true;
                //AddTasks();
            }

            close_application = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(TasksPage));
            lbxMonday = new ListBox();
            lbxTuesday = new ListBox();
            lbxWednesday = new ListBox();
            lbxThursday = new ListBox();
            lbxFriday = new ListBox();
            lbxSaturday = new ListBox();
            lbxSunday = new ListBox();
            cbChooseInformation = new ComboBox();
            btAddTask = new Button();
            DeleteTaskButton = new Button();
            RefreshButton = new Button();
            TaskCompletedbutton = new Button();
            BackToMenuButton = new Button();
            SuspendLayout();
            // 
            // lbxMonday
            // 
            lbxMonday.BackColor = Color.FromArgb(239, 218, 215);
            lbxMonday.BorderStyle = BorderStyle.None;
            lbxMonday.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbxMonday.FormattingEnabled = true;
            lbxMonday.ItemHeight = 25;
            lbxMonday.Location = new Point(0, 105);
            lbxMonday.Name = "lbxMonday";
            lbxMonday.Size = new Size(353, 400);
            lbxMonday.TabIndex = 0;
            lbxMonday.DoubleClick += ShowDescMonday_Click;
            // 
            // lbxTuesday
            // 
            lbxTuesday.BackColor = Color.FromArgb(239, 218, 215);
            lbxTuesday.BorderStyle = BorderStyle.None;
            lbxTuesday.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbxTuesday.FormattingEnabled = true;
            lbxTuesday.ItemHeight = 25;
            lbxTuesday.Location = new Point(359, 105);
            lbxTuesday.Name = "lbxTuesday";
            lbxTuesday.Size = new Size(344, 400);
            lbxTuesday.TabIndex = 1;
            lbxTuesday.DoubleClick += ShowDescTuesday_Click;
            // 
            // lbxWednesday
            // 
            lbxWednesday.BackColor = Color.FromArgb(239, 218, 215);
            lbxWednesday.BorderStyle = BorderStyle.None;
            lbxWednesday.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbxWednesday.FormattingEnabled = true;
            lbxWednesday.ItemHeight = 25;
            lbxWednesday.Location = new Point(709, 105);
            lbxWednesday.Name = "lbxWednesday";
            lbxWednesday.Size = new Size(350, 400);
            lbxWednesday.TabIndex = 2;
            lbxWednesday.DoubleClick += ShowDescWednesday_Click;
            // 
            // lbxThursday
            // 
            lbxThursday.BackColor = Color.FromArgb(239, 218, 215);
            lbxThursday.BorderStyle = BorderStyle.None;
            lbxThursday.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbxThursday.FormattingEnabled = true;
            lbxThursday.ItemHeight = 25;
            lbxThursday.Location = new Point(1065, 105);
            lbxThursday.Name = "lbxThursday";
            lbxThursday.RightToLeft = RightToLeft.No;
            lbxThursday.Size = new Size(347, 400);
            lbxThursday.TabIndex = 3;
            lbxThursday.DoubleClick += ShowDescThursday_Click;
            // 
            // lbxFriday
            // 
            lbxFriday.BackColor = Color.FromArgb(239, 218, 215);
            lbxFriday.BorderStyle = BorderStyle.None;
            lbxFriday.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbxFriday.FormattingEnabled = true;
            lbxFriday.ItemHeight = 25;
            lbxFriday.Location = new Point(0, 551);
            lbxFriday.Name = "lbxFriday";
            lbxFriday.Size = new Size(353, 400);
            lbxFriday.TabIndex = 4;
            lbxFriday.DoubleClick += ShowDescFriday_Click;
            // 
            // lbxSaturday
            // 
            lbxSaturday.BackColor = Color.FromArgb(239, 218, 215);
            lbxSaturday.BorderStyle = BorderStyle.None;
            lbxSaturday.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbxSaturday.FormattingEnabled = true;
            lbxSaturday.ItemHeight = 25;
            lbxSaturday.Location = new Point(359, 551);
            lbxSaturday.Name = "lbxSaturday";
            lbxSaturday.Size = new Size(344, 400);
            lbxSaturday.TabIndex = 5;
            lbxSaturday.DoubleClick += ShowDescSaturday_Click;
            // 
            // lbxSunday
            // 
            lbxSunday.BackColor = Color.FromArgb(239, 218, 215);
            lbxSunday.BorderStyle = BorderStyle.None;
            lbxSunday.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbxSunday.FormattingEnabled = true;
            lbxSunday.ItemHeight = 25;
            lbxSunday.Location = new Point(709, 551);
            lbxSunday.Name = "lbxSunday";
            lbxSunday.Size = new Size(350, 400);
            lbxSunday.TabIndex = 6;
            lbxSunday.DoubleClick += ShowDescSunday_Click;
            // 
            // cbChooseInformation
            // 
            cbChooseInformation.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChooseInformation.FormattingEnabled = true;
            cbChooseInformation.Location = new Point(1116, 562);
            cbChooseInformation.Name = "cbChooseInformation";
            cbChooseInformation.Size = new Size(247, 23);
            cbChooseInformation.TabIndex = 7;
            // 
            // btAddTask
            // 
            btAddTask.BackColor = Color.FromArgb(0, 204, 116);
            btAddTask.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btAddTask.Location = new Point(1116, 666);
            btAddTask.Name = "btAddTask";
            btAddTask.Size = new Size(247, 58);
            btAddTask.TabIndex = 8;
            btAddTask.Text = "Add Task";
            btAddTask.UseVisualStyleBackColor = false;
            btAddTask.Click += btAddTask_Click;
            // 
            // DeleteTaskButton
            // 
            DeleteTaskButton.BackColor = Color.FromArgb(255, 73, 152);
            DeleteTaskButton.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteTaskButton.Location = new Point(1116, 730);
            DeleteTaskButton.Name = "DeleteTaskButton";
            DeleteTaskButton.Size = new Size(247, 58);
            DeleteTaskButton.TabIndex = 9;
            DeleteTaskButton.Text = "Delete Task";
            DeleteTaskButton.UseVisualStyleBackColor = false;
            DeleteTaskButton.Click += DeleteTaskButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.FromArgb(0, 204, 116);
            RefreshButton.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            RefreshButton.Location = new Point(1116, 602);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(247, 58);
            RefreshButton.TabIndex = 10;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // TaskCompletedbutton
            // 
            TaskCompletedbutton.BackColor = Color.FromArgb(0, 204, 116);
            TaskCompletedbutton.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            TaskCompletedbutton.Location = new Point(1116, 794);
            TaskCompletedbutton.Name = "TaskCompletedbutton";
            TaskCompletedbutton.Size = new Size(247, 58);
            TaskCompletedbutton.TabIndex = 11;
            TaskCompletedbutton.Text = "Task Completed";
            TaskCompletedbutton.UseVisualStyleBackColor = false;
            TaskCompletedbutton.Click += TaskCompletedbutton_Click;
            // 
            // BackToMenuButton
            // 
            BackToMenuButton.BackColor = Color.FromArgb(47, 62, 131);
            BackToMenuButton.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            BackToMenuButton.ForeColor = Color.FromArgb(236, 238, 245);
            BackToMenuButton.Location = new Point(1116, 858);
            BackToMenuButton.Name = "BackToMenuButton";
            BackToMenuButton.Size = new Size(247, 58);
            BackToMenuButton.TabIndex = 12;
            BackToMenuButton.Text = "Back To Menu";
            BackToMenuButton.UseVisualStyleBackColor = false;
            BackToMenuButton.Click += BackToMenuButton_Click;
            // 
            // TasksPage
            // 
            BackColor = Color.FromArgb(21, 114, 161);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1414, 953);
            Controls.Add(BackToMenuButton);
            Controls.Add(TaskCompletedbutton);
            Controls.Add(RefreshButton);
            Controls.Add(DeleteTaskButton);
            Controls.Add(btAddTask);
            Controls.Add(cbChooseInformation);
            Controls.Add(lbxSunday);
            Controls.Add(lbxSaturday);
            Controls.Add(lbxFriday);
            Controls.Add(lbxThursday);
            Controls.Add(lbxWednesday);
            Controls.Add(lbxTuesday);
            Controls.Add(lbxMonday);
            DoubleBuffered = true;
            Name = "TasksPage";
            Text = "Tasks";
            FormClosing += AnyForm_FormClosing;
            ResumeLayout(false);
        }

        private ListBox lbxMonday;
        private ListBox lbxTuesday;
        private ListBox lbxWednesday;
        private ListBox lbxThursday;
        private ListBox lbxFriday;
        private ListBox lbxSaturday;
        private ListBox lbxSunday;
        private Button btAddTask;
        private Button DeleteTaskButton;
        private Button RefreshButton;
        private Button TaskCompletedbutton;
        private Button BackToMenuButton;
        private ComboBox cbChooseInformation;

        private void btAddTask_Click(object sender, EventArgs e)
        {
            AddTasksPage addTasksPage = new AddTasksPage(taskManager, this, loggedInUser);
            this.Hide();
            addTasksPage.Show();
        }

        private void AddTasks()
        {
            lbxMonday.Items.Clear();
            lbxTuesday.Items.Clear();
            lbxWednesday.Items.Clear();
            lbxThursday.Items.Clear();
            lbxFriday.Items.Clear();
            lbxSaturday.Items.Clear();
            lbxSunday.Items.Clear();

            if (cbChooseInformation.SelectedItem == "All tasks")
            {
                foreach (Task task in this.taskManager.GetAllTasks(loggedInUser))
                {
                    string day = task.DayOfWeek;
                    switch (day)
                    {
                        case "Monday":
                            lbxMonday.Items.Add(task.TaskForCalendar);
                            break;
                        case "Tuesday":
                            lbxTuesday.Items.Add(task.TaskForCalendar);
                            break;
                        case "Wednesday":
                            lbxWednesday.Items.Add(task.TaskForCalendar);
                            break;
                        case "Thursday":
                            lbxThursday.Items.Add(task.TaskForCalendar);
                            break;
                        case "Friday":
                            lbxFriday.Items.Add(task.TaskForCalendar);
                            break;
                        case "Saturday":
                            lbxSaturday.Items.Add(task.TaskForCalendar);
                            break;
                        case "Sunday":
                            lbxSunday.Items.Add(task.TaskForCalendar);
                            break;
                    }
                }
            }
            else
            {
                foreach (Task task in this.taskManager.GetAllTasks(loggedInUser))
                {
                    taskCategories taskCategory = (taskCategories)Enum.Parse(typeof(taskCategories), cbChooseInformation.SelectedItem.ToString());
                    if (task.GetCategory == taskCategory)
                    {
                        string day = task.DayOfWeek;
                        switch (day)
                        {
                            case "Monday":
                                lbxMonday.Items.Add(task.TaskForCalendar);
                                break;
                            case "Tuesday":
                                lbxTuesday.Items.Add(task.TaskForCalendar);
                                break;
                            case "Wednesday":
                                lbxWednesday.Items.Add(task.TaskForCalendar);
                                break;
                            case "Thursday":
                                lbxThursday.Items.Add(task.TaskForCalendar);
                                break;
                            case "Friday":
                                lbxFriday.Items.Add(task.TaskForCalendar);
                                break;
                            case "Saturday":
                                lbxSaturday.Items.Add(task.TaskForCalendar);
                                break;
                            case "Sunday":
                                lbxSunday.Items.Add(task.TaskForCalendar);
                                break;
                        }
                    }
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }

        public void RefreshPage()
        {
            AddTasks();
            if (taskManager.GetAllTasks(loggedInUser).Count > 0)
            {
                DeleteTaskButton.Enabled = true;
                //AddTasks();
            }
        }

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            if (lbxMonday.SelectedItem != null)
            {
                taskManager.DeleteTask(lbxMonday.SelectedItem.ToString(), "Monday");
            }
            if (lbxTuesday.SelectedItem != null)
            {
                taskManager.DeleteTask(lbxTuesday.SelectedItem.ToString(), "Tuesday");
            }
            if (lbxWednesday.SelectedItem != null)
            {
                taskManager.DeleteTask(lbxWednesday.SelectedItem.ToString(), "Wednesday");
            }
            if (lbxThursday.SelectedItem != null)
            {
                taskManager.DeleteTask(lbxThursday.SelectedItem.ToString(), "Thursday");
            }
            if (lbxFriday.SelectedItem != null)
            {
                if (!lbxFriday.SelectedItem.ToString().Contains("Expenses"))
                {
                    taskManager.DeleteTask(lbxFriday.SelectedItem.ToString(), "Friday");
                }
                else
                {
                    MessageBox.Show("You are not allowed to delete expenses announcements");
                }
            }
            if (lbxSaturday.SelectedItem != null)
            {
                taskManager.DeleteTask(lbxSaturday.SelectedItem.ToString(), "Saturday");
            }
            if (lbxSunday.SelectedItem != null)
            {
                taskManager.DeleteTask(lbxSunday.SelectedItem.ToString(), "Sunday");
            }
            AddTasks();
        }

        private void TaskCompletedbutton_Click(object sender, EventArgs e)
        {
            if (lbxMonday.SelectedItem != null)
            {
                if (!taskManager.TaskCompleted(loggedInUser, lbxMonday.SelectedItem.ToString(), "Monday"))
                {
                    MessageBox.Show("You can not complete other's tasks");
                }
            }
            if (lbxTuesday.SelectedItem != null)
            {
                if (!taskManager.TaskCompleted(loggedInUser, lbxTuesday.SelectedItem.ToString(), "Tuesday"))
                {
                    MessageBox.Show("You can not complete other's tasks");
                }
            }
            if (lbxWednesday.SelectedItem != null)
            {
                if (!taskManager.TaskCompleted(loggedInUser, lbxWednesday.SelectedItem.ToString(), "Wednesday"))
                {
                    MessageBox.Show("You can not complete other's tasks");
                }
            }
            if (lbxThursday.SelectedItem != null)
            {
                if (!taskManager.TaskCompleted(loggedInUser, lbxThursday.SelectedItem.ToString(), "Thursday"))
                {
                    MessageBox.Show("You can not complete other's tasks");
                }
            }
            if (lbxFriday.SelectedItem != null)
            {
                if (!taskManager.TaskCompleted(loggedInUser, lbxFriday.SelectedItem.ToString(), "Friday"))
                {
                    MessageBox.Show("You can not complete other's tasks");
                }
            }
            if (lbxSaturday.SelectedItem != null)
            {
                if (!taskManager.TaskCompleted(loggedInUser,lbxSaturday.SelectedItem.ToString(), "Saturday"))
                {
                    MessageBox.Show("You can not complete other's tasks");
                }
            }
            if (lbxSunday.SelectedItem != null)
            {
                if (!taskManager.TaskCompleted(loggedInUser, lbxSunday.SelectedItem.ToString(), "Sunday"))
                {
                    MessageBox.Show("You can not complete other's tasks");
                }
            }
            AddTasks();
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            close_application = false;
            this.Close();
            menuPage.Show();
        }

        private void ShowDescMonday_Click(object sender, EventArgs e)
        {
            if (lbxMonday.SelectedItem != null)
            {
                MessageBox.Show($"Description: {taskManager.GetTaskDescription(lbxMonday.SelectedItem.ToString(), "Monday")}");
            }
            
            else
            {
                MessageBox.Show("Select Task");
            }
        }
        private void ShowDescTuesday_Click(object sender, EventArgs e)
        {

            if (lbxTuesday.SelectedItem != null)
            {
                MessageBox.Show($"Description: {taskManager.GetTaskDescription(lbxTuesday.SelectedItem.ToString(), "Tuesday")}");
            }           
            else
            {
                MessageBox.Show("Select Task");
            }
        }
        private void ShowDescWednesday_Click(object sender, EventArgs e)
        {
            
            if (lbxWednesday.SelectedItem != null)
            {
                MessageBox.Show($"Description: {taskManager.GetTaskDescription(lbxWednesday.SelectedItem.ToString(), "Wednesday")}");
            }           
            else
            {
                MessageBox.Show("Select Task");
            }
        }
        private void ShowDescThursday_Click(object sender, EventArgs e)
        {           
            if (lbxThursday.SelectedItem != null)
            {
                MessageBox.Show($"Description: {taskManager.GetTaskDescription(lbxThursday.SelectedItem.ToString(), "Thursday")}");
            }           
            else
            {
                MessageBox.Show("Select Task");
            }
        }
        private void ShowDescFriday_Click(object sender, EventArgs e)
        {            
            if (lbxFriday.SelectedItem != null)
            {
                MessageBox.Show($"Description: {taskManager.GetTaskDescription(lbxFriday.SelectedItem.ToString(), "Friday")}");
            }           
            else
            {
                MessageBox.Show("Select Task");
            }
        }
        private void ShowDescSaturday_Click(object sender, EventArgs e)
        {           
            if (lbxSaturday.SelectedItem != null)
            {
                MessageBox.Show($"Description: {taskManager.GetTaskDescription(lbxSaturday.SelectedItem.ToString(), "Saturday")}");
            }
            else
            {
                MessageBox.Show("Select Task");
            }
        }
        private void ShowDescSunday_Click(object sender, EventArgs e)
        {           
            if (lbxSunday.SelectedItem != null)
            {
                MessageBox.Show($"Description: {taskManager.GetTaskDescription(lbxSunday.SelectedItem.ToString(), "Sunday")}");
            }
            else
            {
                MessageBox.Show("Select Task");
            }
        }
        private void AnyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close_application)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}

