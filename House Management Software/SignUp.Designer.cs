namespace House_Management_Software
{
    partial class SignUp
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
            FormClosing += AnyForm_FormClosing;

            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            SignUpLable = new Label();
            FirstNameLabel = new Label();
            FirstNameInput = new TextBox();
            EmailAdressInput = new TextBox();
            EmailAdressLable = new Label();
            ApartmentNumberInput = new TextBox();
            ApartmentNumberLable = new Label();
            PasswordInput = new TextBox();
            PasswordLable = new Label();
            ConfirmPasswordInput = new TextBox();
            ConfirmPasswordLable = new Label();
            ApartmentCodeInput = new TextBox();
            ApartmentCodeLable = new Label();
            PhoneNumberInput = new TextBox();
            PhoneNumberLable = new Label();
            LastNameInput = new TextBox();
            LastNameLable = new Label();
            ToLogInPage = new Label();
            HaveAnAccountLable = new Label();
            SignUpSubmitButton = new Button();
            pbSeeImage = new PictureBox();
            Timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbSeeImage).BeginInit();
            SuspendLayout();
            // 
            // SignUpLable
            // 
            SignUpLable.AutoSize = true;
            SignUpLable.Font = new Font("Arial", 25.875F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpLable.ForeColor = Color.FromArgb(0, 204, 116);
            SignUpLable.Location = new Point(564, 20);
            SignUpLable.Name = "SignUpLable";
            SignUpLable.Size = new Size(294, 80);
            SignUpLable.TabIndex = 0;
            SignUpLable.Text = "Sign Up";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Arial", 16.875F, FontStyle.Bold, GraphicsUnit.Point);
            FirstNameLabel.ForeColor = Color.FromArgb(0, 204, 116);
            FirstNameLabel.Location = new Point(235, 128);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(255, 53);
            FirstNameLabel.TabIndex = 1;
            FirstNameLabel.Text = "First Name";
            // 
            // FirstNameInput
            // 
            FirstNameInput.BackColor = Color.White;
            FirstNameInput.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameInput.Location = new Point(235, 184);
            FirstNameInput.Multiline = true;
            FirstNameInput.Name = "FirstNameInput";
            FirstNameInput.Size = new Size(401, 59);
            FirstNameInput.TabIndex = 3;
            // 
            // EmailAdressInput
            // 
            EmailAdressInput.BackColor = Color.White;
            EmailAdressInput.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmailAdressInput.Location = new Point(235, 343);
            EmailAdressInput.Multiline = true;
            EmailAdressInput.Name = "EmailAdressInput";
            EmailAdressInput.Size = new Size(401, 59);
            EmailAdressInput.TabIndex = 5;
            // 
            // EmailAdressLable
            // 
            EmailAdressLable.AutoSize = true;
            EmailAdressLable.Font = new Font("Arial", 16.875F, FontStyle.Bold, GraphicsUnit.Point);
            EmailAdressLable.ForeColor = Color.FromArgb(0, 204, 116);
            EmailAdressLable.Location = new Point(235, 287);
            EmailAdressLable.Name = "EmailAdressLable";
            EmailAdressLable.Size = new Size(300, 53);
            EmailAdressLable.TabIndex = 4;
            EmailAdressLable.Text = "Email adress";
            // 
            // ApartmentNumberInput
            // 
            ApartmentNumberInput.BackColor = Color.White;
            ApartmentNumberInput.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ApartmentNumberInput.Location = new Point(235, 506);
            ApartmentNumberInput.Multiline = true;
            ApartmentNumberInput.Name = "ApartmentNumberInput";
            ApartmentNumberInput.Size = new Size(401, 59);
            ApartmentNumberInput.TabIndex = 7;
            // 
            // ApartmentNumberLable
            // 
            ApartmentNumberLable.AutoSize = true;
            ApartmentNumberLable.Font = new Font("Arial", 16.875F, FontStyle.Bold, GraphicsUnit.Point);
            ApartmentNumberLable.ForeColor = Color.FromArgb(0, 204, 116);
            ApartmentNumberLable.Location = new Point(235, 450);
            ApartmentNumberLable.Name = "ApartmentNumberLable";
            ApartmentNumberLable.Size = new Size(423, 53);
            ApartmentNumberLable.TabIndex = 6;
            ApartmentNumberLable.Text = "Apartment number";
            // 
            // PasswordInput
            // 
            PasswordInput.BackColor = Color.White;
            PasswordInput.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordInput.Location = new Point(235, 664);
            PasswordInput.Multiline = true;
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(401, 59);
            PasswordInput.TabIndex = 9;
            // 
            // PasswordLable
            // 
            PasswordLable.AutoSize = true;
            PasswordLable.Font = new Font("Arial", 16.875F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLable.ForeColor = Color.FromArgb(0, 204, 116);
            PasswordLable.Location = new Point(235, 608);
            PasswordLable.Name = "PasswordLable";
            PasswordLable.Size = new Size(235, 53);
            PasswordLable.TabIndex = 8;
            PasswordLable.Text = "Password";
            // 
            // ConfirmPasswordInput
            // 
            ConfirmPasswordInput.BackColor = Color.White;
            ConfirmPasswordInput.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmPasswordInput.Location = new Point(811, 664);
            ConfirmPasswordInput.Multiline = true;
            ConfirmPasswordInput.Name = "ConfirmPasswordInput";
            ConfirmPasswordInput.Size = new Size(426, 59);
            ConfirmPasswordInput.TabIndex = 17;
            // 
            // ConfirmPasswordLable
            // 
            ConfirmPasswordLable.AutoSize = true;
            ConfirmPasswordLable.Font = new Font("Arial", 16.875F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmPasswordLable.ForeColor = Color.FromArgb(0, 204, 116);
            ConfirmPasswordLable.Location = new Point(811, 608);
            ConfirmPasswordLable.Name = "ConfirmPasswordLable";
            ConfirmPasswordLable.Size = new Size(419, 53);
            ConfirmPasswordLable.TabIndex = 16;
            ConfirmPasswordLable.Text = "Confirm Password";
            // 
            // ApartmentCodeInput
            // 
            ApartmentCodeInput.BackColor = Color.White;
            ApartmentCodeInput.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ApartmentCodeInput.Location = new Point(811, 506);
            ApartmentCodeInput.Multiline = true;
            ApartmentCodeInput.Name = "ApartmentCodeInput";
            ApartmentCodeInput.Size = new Size(426, 59);
            ApartmentCodeInput.TabIndex = 15;
            // 
            // ApartmentCodeLable
            // 
            ApartmentCodeLable.AutoSize = true;
            ApartmentCodeLable.Font = new Font("Arial", 16.875F, FontStyle.Bold, GraphicsUnit.Point);
            ApartmentCodeLable.ForeColor = Color.FromArgb(0, 204, 116);
            ApartmentCodeLable.Location = new Point(811, 450);
            ApartmentCodeLable.Name = "ApartmentCodeLable";
            ApartmentCodeLable.Size = new Size(370, 53);
            ApartmentCodeLable.TabIndex = 14;
            ApartmentCodeLable.Text = "Apartment Code";
            // 
            // PhoneNumberInput
            // 
            PhoneNumberInput.BackColor = Color.White;
            PhoneNumberInput.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberInput.Location = new Point(811, 343);
            PhoneNumberInput.Multiline = true;
            PhoneNumberInput.Name = "PhoneNumberInput";
            PhoneNumberInput.Size = new Size(426, 59);
            PhoneNumberInput.TabIndex = 13;
            // 
            // PhoneNumberLable
            // 
            PhoneNumberLable.AutoSize = true;
            PhoneNumberLable.Font = new Font("Arial", 16.875F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneNumberLable.ForeColor = Color.FromArgb(0, 204, 116);
            PhoneNumberLable.Location = new Point(811, 287);
            PhoneNumberLable.Name = "PhoneNumberLable";
            PhoneNumberLable.Size = new Size(336, 53);
            PhoneNumberLable.TabIndex = 12;
            PhoneNumberLable.Text = "Phone number";
            // 
            // LastNameInput
            // 
            LastNameInput.BackColor = Color.White;
            LastNameInput.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameInput.Location = new Point(811, 184);
            LastNameInput.Multiline = true;
            LastNameInput.Name = "LastNameInput";
            LastNameInput.Size = new Size(426, 59);
            LastNameInput.TabIndex = 11;
            // 
            // LastNameLable
            // 
            LastNameLable.AutoSize = true;
            LastNameLable.Font = new Font("Arial", 16.875F, FontStyle.Bold, GraphicsUnit.Point);
            LastNameLable.ForeColor = Color.FromArgb(0, 204, 116);
            LastNameLable.Location = new Point(811, 128);
            LastNameLable.Name = "LastNameLable";
            LastNameLable.Size = new Size(250, 53);
            LastNameLable.TabIndex = 10;
            LastNameLable.Text = "Last Name";
            // 
            // ToLogInPage
            // 
            ToLogInPage.AutoSize = true;
            ToLogInPage.Font = new Font("Arial", 10.875F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            ToLogInPage.ForeColor = Color.FromArgb(255, 73, 152);
            ToLogInPage.Location = new Point(632, 891);
            ToLogInPage.Name = "ToLogInPage";
            ToLogInPage.Size = new Size(103, 34);
            ToLogInPage.TabIndex = 18;
            ToLogInPage.Text = "Log In";
            ToLogInPage.Click += ToLogInPage_Click;
            // 
            // HaveAnAccountLable
            // 
            HaveAnAccountLable.AutoSize = true;
            HaveAnAccountLable.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            HaveAnAccountLable.ForeColor = Color.FromArgb(255, 73, 152);
            HaveAnAccountLable.Location = new Point(514, 854);
            HaveAnAccountLable.Name = "HaveAnAccountLable";
            HaveAnAccountLable.Size = new Size(318, 37);
            HaveAnAccountLable.TabIndex = 19;
            HaveAnAccountLable.Text = "Already have an account?";
            // 
            // SignUpSubmitButton
            // 
            SignUpSubmitButton.BackColor = Color.FromArgb(47, 62, 131);
            SignUpSubmitButton.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpSubmitButton.ForeColor = Color.White;
            SignUpSubmitButton.Location = new Point(593, 769);
            SignUpSubmitButton.Name = "SignUpSubmitButton";
            SignUpSubmitButton.Size = new Size(191, 71);
            SignUpSubmitButton.TabIndex = 20;
            SignUpSubmitButton.Text = "Submit";
            SignUpSubmitButton.UseVisualStyleBackColor = false;
            SignUpSubmitButton.Click += SignUpSubmitButton_Click;
            // 
            // pbSeeImage
            // 
            pbSeeImage.BackColor = Color.White;
            pbSeeImage.Image = (Image)resources.GetObject("pbSeeImage.Image");
            pbSeeImage.Location = new Point(591, 678);
            pbSeeImage.Name = "pbSeeImage";
            pbSeeImage.Size = new Size(45, 45);
            pbSeeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSeeImage.TabIndex = 21;
            pbSeeImage.TabStop = false;
            pbSeeImage.Click += pbSeeImage_Click;
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 238, 245);
            ClientSize = new Size(1414, 953);
            Controls.Add(pbSeeImage);
            Controls.Add(SignUpSubmitButton);
            Controls.Add(HaveAnAccountLable);
            Controls.Add(ToLogInPage);
            Controls.Add(ConfirmPasswordInput);
            Controls.Add(ConfirmPasswordLable);
            Controls.Add(ApartmentCodeInput);
            Controls.Add(ApartmentCodeLable);
            Controls.Add(PhoneNumberInput);
            Controls.Add(PhoneNumberLable);
            Controls.Add(LastNameInput);
            Controls.Add(LastNameLable);
            Controls.Add(PasswordInput);
            Controls.Add(PasswordLable);
            Controls.Add(ApartmentNumberInput);
            Controls.Add(ApartmentNumberLable);
            Controls.Add(EmailAdressInput);
            Controls.Add(EmailAdressLable);
            Controls.Add(FirstNameInput);
            Controls.Add(FirstNameLabel);
            Controls.Add(SignUpLable);
            Name = "SignUp";
            Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)pbSeeImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SignUpLable;
        private Label FirstNameLabel;
        private TextBox FirstNameInput;
        private TextBox EmailAdressInput;
        private Label EmailAdressLable;
        private TextBox ApartmentNumberInput;
        private Label ApartmentNumberLable;
        private TextBox PasswordInput;
        private Label PasswordLable;
        private TextBox ConfirmPasswordInput;
        private Label ConfirmPasswordLable;
        private TextBox ApartmentCodeInput;
        private Label ApartmentCodeLable;
        private TextBox PhoneNumberInput;
        private Label PhoneNumberLable;
        private TextBox LastNameInput;
        private Label LastNameLable;
        private Label ToLogInPage;
        private Label HaveAnAccountLable;
        private Button SignUpSubmitButton;
        private PictureBox pbSeeImage;
        private System.Windows.Forms.Timer Timer;
    }
}