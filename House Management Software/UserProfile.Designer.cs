namespace House_Management_Software
{
    partial class UserProfile
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            UserFLNameLabel = new Label();
            pbLogo = new PictureBox();
            tbUsername = new TextBox();
            UsernameLabel = new Label();
            ChangeButton = new Button();
            PhoneNumberLabel = new Label();
            tbPhoneNumber = new TextBox();
            PasswordLabel = new Label();
            tbPassword = new TextBox();
            ConfirmPasswordLabel = new Label();
            tbConfirmPassword = new TextBox();
            ApartLabel = new Label();
            BackToMenuButton = new Button();
            pbSeeImage = new PictureBox();
            Timer = new System.Windows.Forms.Timer(components);
            CautionLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSeeImage).BeginInit();
            SuspendLayout();
            // 
            // UserFLNameLabel
            // 
            UserFLNameLabel.AutoSize = true;
            UserFLNameLabel.Font = new Font("Arial", 25.125F, FontStyle.Bold, GraphicsUnit.Point);
            UserFLNameLabel.ForeColor = Color.FromArgb(255, 73, 152);
            UserFLNameLabel.Location = new Point(518, 19);
            UserFLNameLabel.Margin = new Padding(4, 0, 4, 0);
            UserFLNameLabel.Name = "UserFLNameLabel";
            UserFLNameLabel.Size = new Size(0, 78);
            UserFLNameLabel.TabIndex = 0;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(11, 128);
            pbLogo.Margin = new Padding(4, 2, 4, 2);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(409, 471);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.FromArgb(198, 240, 214);
            tbUsername.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            tbUsername.Location = new Point(982, 124);
            tbUsername.Margin = new Padding(4, 2, 4, 2);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(366, 87);
            tbUsername.TabIndex = 2;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Arial", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameLabel.Location = new Point(464, 154);
            UsernameLabel.Margin = new Padding(4, 0, 4, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(185, 62);
            UsernameLabel.TabIndex = 3;
            UsernameLabel.Text = "Email:";
            // 
            // ChangeButton
            // 
            ChangeButton.BackColor = Color.FromArgb(0, 204, 116);
            ChangeButton.Location = new Point(1001, 585);
            ChangeButton.Margin = new Padding(4, 2, 4, 2);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(366, 77);
            ChangeButton.TabIndex = 4;
            ChangeButton.Text = "Apply Changes";
            ChangeButton.UseVisualStyleBackColor = false;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Font = new Font("Arial", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneNumberLabel.Location = new Point(464, 256);
            PhoneNumberLabel.Margin = new Padding(4, 0, 4, 0);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(418, 62);
            PhoneNumberLabel.TabIndex = 5;
            PhoneNumberLabel.Text = "Phone Number:";
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.BackColor = Color.FromArgb(198, 240, 214);
            tbPhoneNumber.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            tbPhoneNumber.Location = new Point(982, 224);
            tbPhoneNumber.Margin = new Padding(4, 2, 4, 2);
            tbPhoneNumber.Multiline = true;
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(366, 87);
            tbPhoneNumber.TabIndex = 6;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Arial", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(464, 358);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(294, 62);
            PasswordLabel.TabIndex = 7;
            PasswordLabel.Text = "Password:";
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.FromArgb(198, 240, 214);
            tbPassword.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            tbPassword.Location = new Point(982, 326);
            tbPassword.Margin = new Padding(4, 2, 4, 2);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(366, 87);
            tbPassword.TabIndex = 8;
            // 
            // ConfirmPasswordLabel
            // 
            ConfirmPasswordLabel.AutoSize = true;
            ConfirmPasswordLabel.Font = new Font("Arial", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmPasswordLabel.Location = new Point(464, 457);
            ConfirmPasswordLabel.Margin = new Padding(4, 0, 4, 0);
            ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            ConfirmPasswordLabel.Size = new Size(512, 62);
            ConfirmPasswordLabel.TabIndex = 9;
            ConfirmPasswordLabel.Text = "Confirm Password:";
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.BackColor = Color.FromArgb(198, 240, 214);
            tbConfirmPassword.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            tbConfirmPassword.Location = new Point(982, 431);
            tbConfirmPassword.Margin = new Padding(4, 2, 4, 2);
            tbConfirmPassword.Multiline = true;
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(366, 87);
            tbConfirmPassword.TabIndex = 10;
            // 
            // ApartLabel
            // 
            ApartLabel.AutoSize = true;
            ApartLabel.Font = new Font("Arial", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            ApartLabel.ForeColor = Color.FromArgb(255, 73, 152);
            ApartLabel.Location = new Point(1068, 26);
            ApartLabel.Margin = new Padding(4, 0, 4, 0);
            ApartLabel.Name = "ApartLabel";
            ApartLabel.Size = new Size(0, 62);
            ApartLabel.TabIndex = 11;
            // 
            // BackToMenuButton
            // 
            BackToMenuButton.BackColor = Color.FromArgb(47, 62, 131);
            BackToMenuButton.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            BackToMenuButton.ForeColor = Color.White;
            BackToMenuButton.Location = new Point(603, 812);
            BackToMenuButton.Margin = new Padding(4, 2, 4, 2);
            BackToMenuButton.Name = "BackToMenuButton";
            BackToMenuButton.Size = new Size(279, 70);
            BackToMenuButton.TabIndex = 13;
            BackToMenuButton.Text = "Back To Menu";
            BackToMenuButton.UseVisualStyleBackColor = false;
            BackToMenuButton.Click += BackToMenuButton_Click;
            // 
            // pbSeeImage
            // 
            pbSeeImage.BackColor = Color.FromArgb(198, 240, 214);
            pbSeeImage.Image = (Image)resources.GetObject("pbSeeImage.Image");
            pbSeeImage.Location = new Point(1304, 348);
            pbSeeImage.Margin = new Padding(4, 2, 4, 2);
            pbSeeImage.Name = "pbSeeImage";
            pbSeeImage.Size = new Size(45, 45);
            pbSeeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSeeImage.TabIndex = 14;
            pbSeeImage.TabStop = false;
            pbSeeImage.Click += pbSeeImage_Click;
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // CautionLabel
            // 
            CautionLabel.AutoSize = true;
            CautionLabel.Font = new Font("Candara", 10.125F, FontStyle.Italic, GraphicsUnit.Point);
            CautionLabel.Location = new Point(11, 897);
            CautionLabel.Margin = new Padding(4, 0, 4, 0);
            CautionLabel.Name = "CautionLabel";
            CautionLabel.Size = new Size(1289, 33);
            CautionLabel.TabIndex = 15;
            CautionLabel.Text = "*In case of applying any changes to the credentials or the password, please confirm them by applying the password";
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 238, 245);
            ClientSize = new Size(1413, 954);
            Controls.Add(CautionLabel);
            Controls.Add(pbSeeImage);
            Controls.Add(BackToMenuButton);
            Controls.Add(ApartLabel);
            Controls.Add(tbConfirmPassword);
            Controls.Add(ConfirmPasswordLabel);
            Controls.Add(tbPassword);
            Controls.Add(PasswordLabel);
            Controls.Add(tbPhoneNumber);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(ChangeButton);
            Controls.Add(UsernameLabel);
            Controls.Add(tbUsername);
            Controls.Add(pbLogo);
            Controls.Add(UserFLNameLabel);
            Margin = new Padding(4, 2, 4, 2);
            Name = "UserProfile";
            Text = "UserProfile";
            FormClosing += AnyForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSeeImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserFLNameLabel;
        private PictureBox pbLogo;
        private TextBox tbUsername;
        private Label UsernameLabel;
        private Button ChangeButton;
        private Label PhoneNumberLabel;
        private TextBox tbPhoneNumber;
        private Label PasswordLabel;
        private TextBox tbPassword;
        private Label ConfirmPasswordLabel;
        private TextBox tbConfirmPassword;
        private Label ApartLabel;
        private Button BackToMenuButton;
        private PictureBox pbSeeImage;
        private System.Windows.Forms.Timer Timer;
        private Label CautionLabel;
    }
}