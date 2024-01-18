using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace House_Management_Software
{
    public partial class AddTasksPage : Form
    {
        TaskManager taskManager;
        private RadioButton rbRadnom;
        private RadioButton rbManuallySelect;
        private ComboBox cbSelectedPerson;
        private Label SelectTypeLabel;
        private Label SelectPersonLabel;
        private Label SelectDateLabel;
        private Button BackToCalendarButton;
        TasksPage tasksPage;
        DataManager dataManager;
        private User current_user;
        private bool close_application;

        public AddTasksPage(TaskManager taskManager, TasksPage tasksPage, User user)
        {
            InitializeComponent();
            this.taskManager = taskManager;
            this.tasksPage = tasksPage;
            this.current_user = user;
            dataManager = new DataManager();
            foreach (taskCategories taskCategory in Enum.GetValues(typeof(taskCategories)))
            {
                if (taskCategory != taskCategories.Expenses)
                {
                    cbTaskCategory.Items.Add(taskCategory);
                }
            }
            dateDone.MinDate = DateTime.Today.AddDays(0);
            dateDone.MaxDate = DateTime.Today.AddDays(6);
            cbTaskCategory.Enabled = false;
            cbSelectedPerson.Enabled = false;
            SelectDateLabel.Enabled = false;
            tbTaskDescription.Enabled = false;
            AddTaskButton.Enabled = false;
            dateDone.Enabled = false;
            cbSelectedPerson.Items.Add(user.GetFirstandLastName);
            cbSelectedPerson.Text = user.GetFirstandLastName;
            close_application = true;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void InitializeComponent()
        {
            tbTaskDescription = new RichTextBox();
            cbTaskCategory = new ComboBox();
            lbInfoTaskDescription = new Label();
            dateDone = new DateTimePicker();
            lbInfoAddTask = new Label();
            AddTaskButton = new Button();
            lbxTasks = new ListBox();
            lbInfoNewTasks = new Label();
            rbRadnom = new RadioButton();
            rbManuallySelect = new RadioButton();
            cbSelectedPerson = new ComboBox();
            SelectTypeLabel = new Label();
            SelectPersonLabel = new Label();
            SelectDateLabel = new Label();
            BackToCalendarButton = new Button();
            SuspendLayout();
            // 
            // tbTaskDescription
            // 
            tbTaskDescription.BackColor = Color.FromArgb(236, 238, 245);
            tbTaskDescription.Location = new Point(25, 681);
            tbTaskDescription.Name = "tbTaskDescription";
            tbTaskDescription.Size = new Size(405, 172);
            tbTaskDescription.TabIndex = 0;
            tbTaskDescription.Text = "";
            // 
            // cbTaskCategory
            // 
            cbTaskCategory.BackColor = Color.FromArgb(236, 238, 245);
            cbTaskCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTaskCategory.FormattingEnabled = true;
            cbTaskCategory.Location = new Point(35, 322);
            cbTaskCategory.Name = "cbTaskCategory";
            cbTaskCategory.Size = new Size(286, 40);
            cbTaskCategory.TabIndex = 1;
            // 
            // lbInfoTaskDescription
            // 
            lbInfoTaskDescription.AutoSize = true;
            lbInfoTaskDescription.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbInfoTaskDescription.Location = new Point(25, 621);
            lbInfoTaskDescription.Name = "lbInfoTaskDescription";
            lbInfoTaskDescription.Size = new Size(265, 40);
            lbInfoTaskDescription.TabIndex = 2;
            lbInfoTaskDescription.Text = "Task Description:";
            // 
            // dateDone
            // 
            dateDone.CalendarMonthBackground = Color.FromArgb(236, 238, 245);
            dateDone.Location = new Point(163, 466);
            dateDone.Name = "dateDone";
            dateDone.Size = new Size(442, 39);
            dateDone.TabIndex = 3;
            // 
            // lbInfoAddTask
            // 
            lbInfoAddTask.AutoSize = true;
            lbInfoAddTask.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lbInfoAddTask.ForeColor = Color.FromArgb(255, 73, 152);
            lbInfoAddTask.Location = new Point(600, 21);
            lbInfoAddTask.Name = "lbInfoAddTask";
            lbInfoAddTask.Size = new Size(235, 56);
            lbInfoAddTask.TabIndex = 4;
            lbInfoAddTask.Text = "Add Task";
            // 
            // AddTaskButton
            // 
            AddTaskButton.BackColor = Color.FromArgb(0, 204, 116);
            AddTaskButton.Font = new Font("Arial", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            AddTaskButton.ForeColor = Color.FromArgb(236, 238, 245);
            AddTaskButton.Location = new Point(546, 701);
            AddTaskButton.Name = "AddTaskButton";
            AddTaskButton.Size = new Size(235, 152);
            AddTaskButton.TabIndex = 5;
            AddTaskButton.Text = "Add New Task";
            AddTaskButton.UseVisualStyleBackColor = false;
            AddTaskButton.Click += btAddTask_Click;
            // 
            // lbxTasks
            // 
            lbxTasks.BackColor = Color.FromArgb(236, 238, 245);
            lbxTasks.FormattingEnabled = true;
            lbxTasks.ItemHeight = 32;
            lbxTasks.Location = new Point(932, 222);
            lbxTasks.Name = "lbxTasks";
            lbxTasks.Size = new Size(445, 292);
            lbxTasks.TabIndex = 6;
            // 
            // lbInfoNewTasks
            // 
            lbInfoNewTasks.AutoSize = true;
            lbInfoNewTasks.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbInfoNewTasks.Location = new Point(932, 167);
            lbInfoNewTasks.Name = "lbInfoNewTasks";
            lbInfoNewTasks.Size = new Size(180, 40);
            lbInfoNewTasks.TabIndex = 8;
            lbInfoNewTasks.Text = "New Tasks:";
            // 
            // rbRadnom
            // 
            rbRadnom.AutoSize = true;
            rbRadnom.Font = new Font("Arial", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            rbRadnom.Location = new Point(35, 139);
            rbRadnom.Name = "rbRadnom";
            rbRadnom.Size = new Size(350, 44);
            rbRadnom.TabIndex = 9;
            rbRadnom.TabStop = true;
            rbRadnom.Text = "Randomly Generate";
            rbRadnom.UseVisualStyleBackColor = true;
            rbRadnom.CheckedChanged += rbRandom_CheckedChanged;
            // 
            // rbManuallySelect
            // 
            rbManuallySelect.AutoSize = true;
            rbManuallySelect.Font = new Font("Arial", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            rbManuallySelect.Location = new Point(424, 139);
            rbManuallySelect.Name = "rbManuallySelect";
            rbManuallySelect.Size = new Size(273, 44);
            rbManuallySelect.TabIndex = 10;
            rbManuallySelect.TabStop = true;
            rbManuallySelect.Text = "Select Yourself";
            rbManuallySelect.UseVisualStyleBackColor = true;
            rbManuallySelect.CheckedChanged += rbManuallySelect_CheckedChanged;
            // 
            // cbSelectedPerson
            // 
            cbSelectedPerson.BackColor = Color.FromArgb(236, 238, 245);
            cbSelectedPerson.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSelectedPerson.FormattingEnabled = true;
            cbSelectedPerson.Location = new Point(424, 322);
            cbSelectedPerson.Name = "cbSelectedPerson";
            cbSelectedPerson.Size = new Size(286, 40);
            cbSelectedPerson.TabIndex = 11;
            // 
            // SelectTypeLabel
            // 
            SelectTypeLabel.AutoSize = true;
            SelectTypeLabel.Font = new Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            SelectTypeLabel.Location = new Point(35, 277);
            SelectTypeLabel.Name = "SelectTypeLabel";
            SelectTypeLabel.Size = new Size(173, 33);
            SelectTypeLabel.TabIndex = 12;
            SelectTypeLabel.Text = "Select Type:";
            // 
            // SelectPersonLabel
            // 
            SelectPersonLabel.AutoSize = true;
            SelectPersonLabel.Font = new Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            SelectPersonLabel.Location = new Point(424, 277);
            SelectPersonLabel.Name = "SelectPersonLabel";
            SelectPersonLabel.Size = new Size(236, 33);
            SelectPersonLabel.TabIndex = 13;
            SelectPersonLabel.Text = "Selected Person:";
            // 
            // SelectDateLabel
            // 
            SelectDateLabel.AutoSize = true;
            SelectDateLabel.Font = new Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            SelectDateLabel.Location = new Point(163, 417);
            SelectDateLabel.Name = "SelectDateLabel";
            SelectDateLabel.Size = new Size(173, 33);
            SelectDateLabel.TabIndex = 14;
            SelectDateLabel.Text = "Select Date:";
            // 
            // BackToCalendarButton
            // 
            BackToCalendarButton.BackColor = Color.FromArgb(47, 62, 131);
            BackToCalendarButton.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            BackToCalendarButton.ForeColor = Color.FromArgb(236, 238, 245);
            BackToCalendarButton.Location = new Point(1098, 782);
            BackToCalendarButton.Name = "BackToCalendarButton";
            BackToCalendarButton.Size = new Size(279, 71);
            BackToCalendarButton.TabIndex = 15;
            BackToCalendarButton.Text = "Back To Calendar";
            BackToCalendarButton.UseVisualStyleBackColor = false;
            BackToCalendarButton.Click += BackToMenuButton_Click;
            // 
            // AddTasksPage
            // 
            BackColor = Color.White;
            ClientSize = new Size(1414, 953);
            Controls.Add(BackToCalendarButton);
            Controls.Add(SelectDateLabel);
            Controls.Add(SelectPersonLabel);
            Controls.Add(SelectTypeLabel);
            Controls.Add(cbSelectedPerson);
            Controls.Add(rbManuallySelect);
            Controls.Add(rbRadnom);
            Controls.Add(lbInfoNewTasks);
            Controls.Add(lbxTasks);
            Controls.Add(AddTaskButton);
            Controls.Add(lbInfoAddTask);
            Controls.Add(dateDone);
            Controls.Add(lbInfoTaskDescription);
            Controls.Add(cbTaskCategory);
            Controls.Add(tbTaskDescription);
            Name = "AddTasksPage";
            FormClosing += AnyForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        private RichTextBox tbTaskDescription;
        private Label lbInfoTaskDescription;
        private DateTimePicker dateDone;
        private Label lbInfoAddTask;
        private Button AddTaskButton;
        private ListBox lbxTasks;
        private Label lbInfoNewTasks;
        private ComboBox cbTaskCategory;


        private void btAddTask_Click(object sender, EventArgs e)
        {
            DateTime date_done = dateDone.Value.Date;
            if (rbRadnom.Checked && cbTaskCategory.SelectedItem != null)
            {
                User user = taskManager.RandomUser(date_done, cbTaskCategory.SelectedItem.ToString(), current_user);
                ProcessATask(user, date_done);
            }
            else if (rbManuallySelect.Checked)
            {
                if(cbSelectedPerson.SelectedIndex >-1 && cbTaskCategory.SelectedItem != null)
                {
                    User user = (dataManager.GetUsers().FirstOrDefault(user => user.GetFirstandLastName == cbSelectedPerson.SelectedItem.ToString()));
                    ProcessATask(user, date_done);
                }
                else
                {
                    MessageBox.Show("Select User");
                }
            }
        }

        public void ProcessATask(User user,DateTime date_done)
        {
            if (user != null)
            {
                if (taskManager.CheckerForSamePeopleTasksDates(cbTaskCategory.SelectedItem.ToString(), date_done).Any())
                {
                    MessageBox.Show($"The task category '{cbTaskCategory.SelectedItem.ToString()}' is already assigned to someone on {date_done.ToShortDateString()}.");
                }
                else
                {
                    if (taskManager.CreateATask(cbTaskCategory.Text, tbTaskDescription.Text, date_done, false, user) == null)
                    {
                        lbxTasks.Items.Add($"{user.FirstName} - {cbTaskCategory.Text} - {date_done.ToString("yyyy-MM-dd")}");
                    }
                    else
                    {
                        MessageBox.Show(taskManager.CreateATask(cbTaskCategory.Text, tbTaskDescription.Text, date_done, false, user));
                    }
                }
            }
            else
            {
                MessageBox.Show("All People are occupied");
            }
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            close_application = false;
            this.Close();
            tasksPage.RefreshPage();
            tasksPage.Show();
        }

        private void rbRandom_CheckedChanged(object sender, EventArgs e)
        {
            cbTaskCategory.Enabled = true;
            cbSelectedPerson.Enabled = false;
            SelectDateLabel.Enabled = true;
            tbTaskDescription.Enabled = true;
            AddTaskButton.Enabled = true;
            dateDone.Enabled = true;
        }

        private void rbManuallySelect_CheckedChanged(object sender, EventArgs e)
        {
            cbTaskCategory.Enabled = true;
            cbSelectedPerson.Enabled = true;
            SelectDateLabel.Enabled = true;
            tbTaskDescription.Enabled = true;
            AddTaskButton.Enabled = true;
            dateDone.Enabled = true;
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
