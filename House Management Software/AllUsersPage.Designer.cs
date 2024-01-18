namespace House_Management_Software
{
    partial class AllUsersPage
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
            lbAllUsers = new ListBox();
            BackToMenuButton = new Button();
            tbSelectedStudentInfo = new TextBox();
            DeleteUserButton = new Button();
            SuspendLayout();
            // 
            // lbAllUsers
            // 
            lbAllUsers.FormattingEnabled = true;
            lbAllUsers.ItemHeight = 32;
            lbAllUsers.Location = new Point(60, 227);
            lbAllUsers.Name = "lbAllUsers";
            lbAllUsers.Size = new Size(780, 516);
            lbAllUsers.TabIndex = 0;
            lbAllUsers.SelectedIndexChanged += lbAllUsers_SelectedIndexChanged;
            // 
            // BackToMenuButton
            // 
            BackToMenuButton.BackColor = Color.FromArgb(47, 62, 131);
            BackToMenuButton.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            BackToMenuButton.ForeColor = Color.FromArgb(236, 238, 245);
            BackToMenuButton.Location = new Point(935, 671);
            BackToMenuButton.Name = "BackToMenuButton";
            BackToMenuButton.Size = new Size(304, 72);
            BackToMenuButton.TabIndex = 1;
            BackToMenuButton.Text = "Back To Menu";
            BackToMenuButton.UseVisualStyleBackColor = false;
            BackToMenuButton.Click += BackToMenuButton_Click;
            // 
            // tbSelectedStudentInfo
            // 
            tbSelectedStudentInfo.Location = new Point(935, 311);
            tbSelectedStudentInfo.Multiline = true;
            tbSelectedStudentInfo.Name = "tbSelectedStudentInfo";
            tbSelectedStudentInfo.ReadOnly = true;
            tbSelectedStudentInfo.Size = new Size(349, 308);
            tbSelectedStudentInfo.TabIndex = 3;
            tbSelectedStudentInfo.Text = "Select a student";
            tbSelectedStudentInfo.TextAlign = HorizontalAlignment.Center;
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.BackColor = Color.FromArgb(255, 73, 152);
            DeleteUserButton.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteUserButton.ForeColor = SystemColors.Control;
            DeleteUserButton.Location = new Point(666, 798);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(174, 143);
            DeleteUserButton.TabIndex = 24;
            DeleteUserButton.Text = "Delete User";
            DeleteUserButton.UseVisualStyleBackColor = false;
            DeleteUserButton.Click += DeleteUserButton_Click;
            // 
            // AllUsersPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 238, 245);
            ClientSize = new Size(1414, 953);
            Controls.Add(DeleteUserButton);
            Controls.Add(tbSelectedStudentInfo);
            Controls.Add(BackToMenuButton);
            Controls.Add(lbAllUsers);
            Name = "AllUsersPage";
            Text = "AllUsersPage";
            FormClosing += AnyForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbAllUsers;
        private Button BackToMenuButton;
        private TextBox tbSelectedStudentInfo;
        private Button DeleteUserButton;
    }
}