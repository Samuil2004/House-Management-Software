using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace House_Management_Software
{
    public partial class TasksAdmin : Form
    {
        private bool close_application;
        MenuPageAdmin menuPageAdmin;
        TaskManager taskManager;

        public TasksAdmin(MenuPageAdmin menuPageAdmin)
        {
            InitializeComponent();
            this.taskManager = new TaskManager();
            this.menuPageAdmin = menuPageAdmin;
            AddTasksAdmin();
            close_application = true;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        public void AnyForm_FormClosing(object sender, FormClosingEventArgs e)
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

        public void btBackToMenu_Click(object sender, EventArgs e)
        {
            menuPageAdmin.Show();
            close_application = false;
            this.Close();
        }

        public void lbAllTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAllTasks.SelectedItem != null)
            {
                tbInfoForTask.ResetText();
                Task selectedTask = taskManager.GetAllTasksForAdmin().FirstOrDefault(selectedTask => selectedTask.TaskAllInfoAdmin.Equals(lbAllTasks.Text));
                tbInfoForTask.Text = selectedTask.GetDetailedInfo;
            }
        }

        public void btTaskWasInvestigated_Click(object sender, EventArgs e)
        {
            if (lbAllTasks.SelectedItem != null)
            {
                Task selectedTask = taskManager.GetAllTasksForAdmin().FirstOrDefault(selectedTask => selectedTask.TaskAllInfoAdmin.Equals(lbAllTasks.Text));
                taskManager.TaskCompletedAdmin(selectedTask);
                AddTasksAdmin();
            }
            else
            {
                MessageBox.Show("Choose a task");
            }
        }
        public void AddTasksAdmin()
        {
            lbAllTasks.Items.Clear();
            tbInfoForTask.ResetText();
            foreach (Task task in taskManager.GetAllTasksForAdmin())
            {
                lbAllTasks.Items.Add(task.TaskAllInfoAdmin);
            }
        }
    }
}
