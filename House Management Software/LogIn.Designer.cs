namespace House_Management_Software
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            LogInLable = new Label();
            UserNameLabel = new Label();
            PasswordLabel = new Label();
            UsernameInput = new TextBox();
            PasswordInput = new TextBox();
            ToSignUpPage = new Label();
            NoAccountLable = new Label();
            LogInSubmitButton = new Button();
            pbSeeImage = new PictureBox();
            Timer = new System.Windows.Forms.Timer(components);
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbSeeImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // LogInLable
            // 
            LogInLable.AutoSize = true;
            LogInLable.Font = new Font("Arial", 30F, FontStyle.Bold, GraphicsUnit.Point);
            LogInLable.ForeColor = Color.FromArgb(0, 204, 116);
            LogInLable.Location = new Point(307, 40);
            LogInLable.Margin = new Padding(2, 0, 2, 0);
            LogInLable.Name = "LogInLable";
            LogInLable.Size = new Size(136, 46);
            LogInLable.TabIndex = 0;
            LogInLable.Text = "Log In";
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Arial", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameLabel.ForeColor = Color.Black;
            UserNameLabel.Location = new Point(327, 118);
            UserNameLabel.Margin = new Padding(2, 0, 2, 0);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(89, 32);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "Email";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Arial", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLabel.ForeColor = Color.Black;
            PasswordLabel.Location = new Point(307, 225);
            PasswordLabel.Margin = new Padding(2, 0, 2, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(143, 32);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password";
            // 
            // UsernameInput
            // 
            UsernameInput.BackColor = Color.White;
            UsernameInput.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameInput.Location = new Point(246, 160);
            UsernameInput.Margin = new Padding(2, 1, 2, 1);
            UsernameInput.Multiline = true;
            UsernameInput.Name = "UsernameInput";
            UsernameInput.PlaceholderText = "Enter email";
            UsernameInput.Size = new Size(275, 39);
            UsernameInput.TabIndex = 3;
            // 
            // PasswordInput
            // 
            PasswordInput.BackColor = Color.White;
            PasswordInput.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordInput.Location = new Point(246, 262);
            PasswordInput.Margin = new Padding(2, 1, 2, 1);
            PasswordInput.Multiline = true;
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PlaceholderText = "Enter password";
            PasswordInput.Size = new Size(275, 39);
            PasswordInput.TabIndex = 5;
            // 
            // ToSignUpPage
            // 
            ToSignUpPage.AutoSize = true;
            ToSignUpPage.Font = new Font("Arial", 10.125F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            ToSignUpPage.ForeColor = Color.FromArgb(255, 73, 152);
            ToSignUpPage.Location = new Point(350, 414);
            ToSignUpPage.Margin = new Padding(2, 0, 2, 0);
            ToSignUpPage.Name = "ToSignUpPage";
            ToSignUpPage.Size = new Size(61, 16);
            ToSignUpPage.TabIndex = 6;
            ToSignUpPage.Text = "Sign Up";
            ToSignUpPage.Click += ToSignUpPage_Click;
            // 
            // NoAccountLable
            // 
            NoAccountLable.AutoSize = true;
            NoAccountLable.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            NoAccountLable.ForeColor = Color.FromArgb(255, 73, 152);
            NoAccountLable.Location = new Point(300, 392);
            NoAccountLable.Margin = new Padding(2, 0, 2, 0);
            NoAccountLable.Name = "NoAccountLable";
            NoAccountLable.Size = new Size(155, 19);
            NoAccountLable.TabIndex = 7;
            NoAccountLable.Text = "Don't have an account?";
            // 
            // LogInSubmitButton
            // 
            LogInSubmitButton.BackColor = Color.FromArgb(47, 62, 131);
            LogInSubmitButton.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            LogInSubmitButton.ForeColor = Color.White;
            LogInSubmitButton.Location = new Point(327, 332);
            LogInSubmitButton.Margin = new Padding(2, 1, 2, 1);
            LogInSubmitButton.Name = "LogInSubmitButton";
            LogInSubmitButton.Size = new Size(103, 33);
            LogInSubmitButton.TabIndex = 8;
            LogInSubmitButton.Text = "Submit";
            LogInSubmitButton.UseVisualStyleBackColor = false;
            LogInSubmitButton.Click += LogInSubmitButton_Click;
            // 
            // pbSeeImage
            // 
            pbSeeImage.BackColor = Color.White;
            pbSeeImage.Image = (Image)resources.GetObject("pbSeeImage.Image");
            pbSeeImage.Location = new Point(495, 271);
            pbSeeImage.Margin = new Padding(2, 1, 2, 1);
            pbSeeImage.Name = "pbSeeImage";
            pbSeeImage.Size = new Size(24, 21);
            pbSeeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSeeImage.TabIndex = 15;
            pbSeeImage.TabStop = false;
            pbSeeImage.Click += pbSeeImage_Click;
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.Transparent;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(-5, 84);
            pbLogo.Margin = new Padding(2, 1, 2, 1);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(247, 270);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 16;
            pbLogo.TabStop = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 238, 245);
            ClientSize = new Size(761, 447);
            Controls.Add(pbLogo);
            Controls.Add(pbSeeImage);
            Controls.Add(LogInSubmitButton);
            Controls.Add(NoAccountLable);
            Controls.Add(ToSignUpPage);
            Controls.Add(PasswordInput);
            Controls.Add(UsernameInput);
            Controls.Add(PasswordLabel);
            Controls.Add(UserNameLabel);
            Controls.Add(LogInLable);
            Name = "LogIn";
            Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)pbSeeImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LogInLable;
        private Label UserNameLabel;
        private Label PasswordLabel;
        private TextBox UsernameInput;
        private TextBox PasswordInput;
        private Label ToSignUpPage;
        private Label NoAccountLable;
        private Button LogInSubmitButton;
        private PictureBox pbSeeImage;
        private System.Windows.Forms.Timer Timer;
        private PictureBox pbLogo;
    }
}