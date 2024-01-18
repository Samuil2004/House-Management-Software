namespace House_Management_Software
{
    partial class TasksAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbAllTasks = new ListBox();
            btBackToMenu = new Button();
            btTaskWasInvestigated = new Button();
            lbInfoTasks = new Label();
            lbInfoTask = new Label();
            tbInfoForTask = new TextBox();
            SuspendLayout();
            // 
            // lbAllTasks
            // 
            lbAllTasks.FormattingEnabled = true;
            lbAllTasks.ItemHeight = 32;
            lbAllTasks.Location = new Point(134, 134);
            lbAllTasks.Margin = new Padding(6);
            lbAllTasks.Name = "lbAllTasks";
            lbAllTasks.Size = new Size(632, 548);
            lbAllTasks.TabIndex = 0;
            lbAllTasks.SelectedIndexChanged += lbAllTasks_SelectedIndexChanged;
            // 
            // btBackToMenu
            // 
            btBackToMenu.BackColor = Color.FromArgb(47, 62, 131);
            btBackToMenu.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btBackToMenu.ForeColor = Color.FromArgb(236, 238, 245);
            btBackToMenu.Location = new Point(1061, 740);
            btBackToMenu.Margin = new Padding(6);
            btBackToMenu.Name = "btBackToMenu";
            btBackToMenu.Size = new Size(225, 77);
            btBackToMenu.TabIndex = 1;
            btBackToMenu.Text = "Go back";
            btBackToMenu.UseVisualStyleBackColor = false;
            btBackToMenu.Click += btBackToMenu_Click;
            // 
            // btTaskWasInvestigated
            // 
            btTaskWasInvestigated.BackColor = Color.FromArgb(0, 204, 116);
            btTaskWasInvestigated.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btTaskWasInvestigated.ForeColor = Color.White;
            btTaskWasInvestigated.Location = new Point(297, 740);
            btTaskWasInvestigated.Margin = new Padding(6);
            btTaskWasInvestigated.Name = "btTaskWasInvestigated";
            btTaskWasInvestigated.Size = new Size(314, 64);
            btTaskWasInvestigated.TabIndex = 2;
            btTaskWasInvestigated.Text = "Mark as investigated";
            btTaskWasInvestigated.UseVisualStyleBackColor = false;
            btTaskWasInvestigated.Click += btTaskWasInvestigated_Click;
            // 
            // lbInfoTasks
            // 
            lbInfoTasks.AutoSize = true;
            lbInfoTasks.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbInfoTasks.Location = new Point(134, 66);
            lbInfoTasks.Margin = new Padding(6, 0, 6, 0);
            lbInfoTasks.Name = "lbInfoTasks";
            lbInfoTasks.Size = new Size(450, 45);
            lbInfoTasks.TabIndex = 4;
            lbInfoTasks.Text = "All expired and undone tasks:";
            // 
            // lbInfoTask
            // 
            lbInfoTask.AutoSize = true;
            lbInfoTask.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbInfoTask.Location = new Point(951, 211);
            lbInfoTask.Margin = new Padding(6, 0, 6, 0);
            lbInfoTask.Name = "lbInfoTask";
            lbInfoTask.Size = new Size(272, 45);
            lbInfoTask.TabIndex = 5;
            lbInfoTask.Text = "Task information:";
            // 
            // tbInfoForTask
            // 
            tbInfoForTask.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            tbInfoForTask.Location = new Point(951, 283);
            tbInfoForTask.Multiline = true;
            tbInfoForTask.Name = "tbInfoForTask";
            tbInfoForTask.ReadOnly = true;
            tbInfoForTask.Size = new Size(431, 380);
            tbInfoForTask.TabIndex = 27;
            tbInfoForTask.Text = "Select a task";
            tbInfoForTask.TextAlign = HorizontalAlignment.Center;
            // 
            // TasksAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 238, 245);
            ClientSize = new Size(1486, 960);
            Controls.Add(tbInfoForTask);
            Controls.Add(lbInfoTask);
            Controls.Add(lbInfoTasks);
            Controls.Add(btTaskWasInvestigated);
            Controls.Add(btBackToMenu);
            Controls.Add(lbAllTasks);
            Margin = new Padding(6);
            Name = "TasksAdmin";
            Text = "TasksAdmin";
            FormClosing += AnyForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbAllTasks;
        private Button btBackToMenu;
        private Button btTaskWasInvestigated;
        private Label lbInfoTasks;
        private Label lbInfoTask;
        private TextBox tbInfoForTask;
    }
}