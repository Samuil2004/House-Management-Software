namespace House_Management_Software
{
    partial class MenuPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPage));
            RulesButton = new Button();
            GroceryListButton = new Button();
            TasksButton = new Button();
            GarbageScheduleButton = new Button();
            pbUserIcon = new PictureBox();
            pbLogOut = new PictureBox();
            ComplainsButton = new Button();
            EventButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pbUserIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogOut).BeginInit();
            SuspendLayout();
            // 
            // RulesButton
            // 
            RulesButton.BackColor = Color.FromArgb(236, 238, 245);
            RulesButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RulesButton.ForeColor = Color.FromArgb(47, 62, 131);
            RulesButton.Location = new Point(575, 570);
            RulesButton.Name = "RulesButton";
            RulesButton.Size = new Size(342, 332);
            RulesButton.TabIndex = 1;
            RulesButton.Text = "Rules";
            RulesButton.UseVisualStyleBackColor = false;
            RulesButton.Click += RulesButton_Click;
            // 
            // GroceryListButton
            // 
            GroceryListButton.BackColor = Color.FromArgb(47, 62, 131);
            GroceryListButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            GroceryListButton.ForeColor = Color.FromArgb(236, 238, 245);
            GroceryListButton.Location = new Point(166, 570);
            GroceryListButton.Name = "GroceryListButton";
            GroceryListButton.Size = new Size(342, 332);
            GroceryListButton.TabIndex = 1;
            GroceryListButton.Text = "Grocery List";
            GroceryListButton.UseVisualStyleBackColor = false;
            GroceryListButton.Click += GroceryListButton_Click;
            // 
            // TasksButton
            // 
            TasksButton.BackColor = Color.FromArgb(47, 62, 131);
            TasksButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TasksButton.ForeColor = Color.FromArgb(236, 238, 245);
            TasksButton.Location = new Point(983, 570);
            TasksButton.Name = "TasksButton";
            TasksButton.Size = new Size(342, 332);
            TasksButton.TabIndex = 2;
            TasksButton.Text = "Tasks";
            TasksButton.UseVisualStyleBackColor = false;
            TasksButton.Click += TasksButton_Click_1;
            // 
            // GarbageScheduleButton
            // 
            GarbageScheduleButton.BackColor = Color.FromArgb(47, 62, 131);
            GarbageScheduleButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            GarbageScheduleButton.ForeColor = Color.FromArgb(236, 238, 245);
            GarbageScheduleButton.Location = new Point(575, 147);
            GarbageScheduleButton.Name = "GarbageScheduleButton";
            GarbageScheduleButton.Size = new Size(342, 332);
            GarbageScheduleButton.TabIndex = 3;
            GarbageScheduleButton.Text = "Garbage Schedule";
            GarbageScheduleButton.UseVisualStyleBackColor = false;
            GarbageScheduleButton.Click += GarbageScheduleButton_Click;
            // 
            // pbUserIcon
            // 
            pbUserIcon.Image = (Image)resources.GetObject("pbUserIcon.Image");
            pbUserIcon.Location = new Point(12, 12);
            pbUserIcon.Name = "pbUserIcon";
            pbUserIcon.Size = new Size(100, 92);
            pbUserIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUserIcon.TabIndex = 5;
            pbUserIcon.TabStop = false;
            pbUserIcon.Click += pbUserIcon_Click;
            // 
            // pbLogOut
            // 
            pbLogOut.Image = (Image)resources.GetObject("pbLogOut.Image");
            pbLogOut.Location = new Point(1292, 4);
            pbLogOut.Name = "pbLogOut";
            pbLogOut.Size = new Size(120, 100);
            pbLogOut.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogOut.TabIndex = 6;
            pbLogOut.TabStop = false;
            pbLogOut.Click += pbLogOut_Click;
            // 
            // ComplainsButton
            // 
            ComplainsButton.BackColor = Color.FromArgb(236, 238, 245);
            ComplainsButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ComplainsButton.ForeColor = Color.FromArgb(47, 62, 131);
            ComplainsButton.Location = new Point(983, 147);
            ComplainsButton.Name = "ComplainsButton";
            ComplainsButton.Size = new Size(342, 332);
            ComplainsButton.TabIndex = 7;
            ComplainsButton.Text = "Complains";
            ComplainsButton.UseVisualStyleBackColor = false;
            ComplainsButton.Click += ComplainsButton_Click;
            // 
            // EventButton
            // 
            EventButton.BackColor = Color.FromArgb(236, 238, 245);
            EventButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            EventButton.ForeColor = Color.FromArgb(47, 62, 131);
            EventButton.Location = new Point(166, 147);
            EventButton.Name = "EventButton";
            EventButton.Size = new Size(342, 332);
            EventButton.TabIndex = 8;
            EventButton.Text = "Events";
            EventButton.UseVisualStyleBackColor = false;
            EventButton.Click += EventButton_Click;
            // 
            // MenuPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1414, 953);
            Controls.Add(EventButton);
            Controls.Add(ComplainsButton);
            Controls.Add(pbLogOut);
            Controls.Add(pbUserIcon);
            Controls.Add(GarbageScheduleButton);
            Controls.Add(TasksButton);
            Controls.Add(GroceryListButton);
            Controls.Add(RulesButton);
            Name = "MenuPage";
            Text = "MenuPage";
            Load += MenuPage_Load;
            ((System.ComponentModel.ISupportInitialize)pbUserIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button RulesButton;
        private Button GroceryListButton;
        private Button TasksButton;
        private Button GarbageScheduleButton;
        private PictureBox pbUserIcon;
        private PictureBox pbLogOut;
        private Button ComplainsButton;
        private Button EventButton;
    }
}