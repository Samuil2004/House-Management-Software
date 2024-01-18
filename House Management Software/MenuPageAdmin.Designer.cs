namespace House_Management_Software
{
    partial class MenuPageAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPageAdmin));
            SeeComlainsButton = new Button();
            button1 = new Button();
            AllUsersButton = new Button();
            btTasks = new Button();
            SeeEventsButton = new Button();
            pbUserIcon = new PictureBox();
            pbLogOut = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbUserIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogOut).BeginInit();
            SuspendLayout();
            // 
            // SeeComlainsButton
            // 
            SeeComlainsButton.BackColor = Color.FromArgb(47, 62, 131);
            SeeComlainsButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SeeComlainsButton.ForeColor = Color.FromArgb(236, 238, 245);
            SeeComlainsButton.Location = new Point(823, 192);
            SeeComlainsButton.Margin = new Padding(4, 2, 4, 2);
            SeeComlainsButton.Name = "SeeComlainsButton";
            SeeComlainsButton.Size = new Size(319, 290);
            SeeComlainsButton.TabIndex = 0;
            SeeComlainsButton.Text = "See Complains";
            SeeComlainsButton.UseVisualStyleBackColor = false;
            SeeComlainsButton.Click += SeeComlainsButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(397, 335);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(7, 9);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // AllUsersButton
            // 
            AllUsersButton.BackColor = Color.FromArgb(47, 62, 131);
            AllUsersButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AllUsersButton.ForeColor = Color.FromArgb(236, 238, 245);
            AllUsersButton.Location = new Point(342, 192);
            AllUsersButton.Margin = new Padding(4, 2, 4, 2);
            AllUsersButton.Name = "AllUsersButton";
            AllUsersButton.Size = new Size(319, 290);
            AllUsersButton.TabIndex = 2;
            AllUsersButton.Text = "All Users";
            AllUsersButton.UseVisualStyleBackColor = false;
            AllUsersButton.Click += AllUsersButton_Click;
            // 
            // btTasks
            // 
            btTasks.BackColor = Color.FromArgb(47, 62, 131);
            btTasks.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btTasks.ForeColor = Color.FromArgb(236, 238, 245);
            btTasks.Location = new Point(823, 561);
            btTasks.Margin = new Padding(6);
            btTasks.Name = "btTasks";
            btTasks.Size = new Size(319, 290);
            btTasks.TabIndex = 3;
            btTasks.Text = "See undone tasks";
            btTasks.UseVisualStyleBackColor = false;
            btTasks.Click += btTasks_Click;
            // 
            // SeeEventsButton
            // 
            SeeEventsButton.BackColor = Color.FromArgb(47, 62, 131);
            SeeEventsButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SeeEventsButton.ForeColor = Color.FromArgb(236, 238, 245);
            SeeEventsButton.Location = new Point(342, 561);
            SeeEventsButton.Margin = new Padding(6);
            SeeEventsButton.Name = "SeeEventsButton";
            SeeEventsButton.Size = new Size(319, 290);
            SeeEventsButton.TabIndex = 4;
            SeeEventsButton.Text = "See events";
            SeeEventsButton.UseVisualStyleBackColor = false;
            SeeEventsButton.Click += SeeEventsButton_Click;
            // 
            // pbUserIcon
            // 
            pbUserIcon.Image = (Image)resources.GetObject("pbUserIcon.Image");
            pbUserIcon.Location = new Point(12, 12);
            pbUserIcon.Name = "pbUserIcon";
            pbUserIcon.Size = new Size(100, 92);
            pbUserIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUserIcon.TabIndex = 6;
            pbUserIcon.TabStop = false;
            pbUserIcon.Click += pbUserIcon_Click;
            // 
            // pbLogOut
            // 
            pbLogOut.Image = (Image)resources.GetObject("pbLogOut.Image");
            pbLogOut.Location = new Point(1281, 12);
            pbLogOut.Name = "pbLogOut";
            pbLogOut.Size = new Size(120, 100);
            pbLogOut.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogOut.TabIndex = 7;
            pbLogOut.TabStop = false;
            pbLogOut.Click += pbLogOut_Click;
            // 
            // MenuPageAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 238, 245);
            ClientSize = new Size(1413, 954);
            Controls.Add(pbLogOut);
            Controls.Add(pbUserIcon);
            Controls.Add(SeeEventsButton);
            Controls.Add(btTasks);
            Controls.Add(AllUsersButton);
            Controls.Add(button1);
            Controls.Add(SeeComlainsButton);
            Margin = new Padding(4, 2, 4, 2);
            Name = "MenuPageAdmin";
            FormClosing += AnyForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbUserIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button SeeComlainsButton;
        private Button button1;
        private Button AllUsersButton;
        private Button btTasks;
        private Button SeeEventsButton;
        private PictureBox pbUserIcon;
        private PictureBox pbLogOut;
    }
}