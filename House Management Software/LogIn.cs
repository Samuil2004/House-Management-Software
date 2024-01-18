using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using House_Management_Software;
using Microsoft.VisualBasic.Logging;

namespace House_Management_Software
{
    public partial class LogIn : Form
    {
        SignUp signUp;
        DataManager dataManager;
        private int counter;
        private User loggedInUser;
        public LogIn()
        {
            InitializeComponent();
            RefreshPage();
            dataManager = new DataManager();
            signUp = new SignUp(this);

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        public void RefreshPage()
        {
            PasswordInput.Text = "";
            PasswordInput.PasswordChar = '*';
            PasswordInput.MaxLength = 14;
            UsernameInput.ResetText();
            PasswordInput.ResetText();
        }

        private void ToSignUpPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            signUp.RefreshPage();
            signUp.ShowDialog();
            this.Show();
        }

        private void LogInSubmitButton_Click(object sender, EventArgs e)
        {
            User user = dataManager.GetUsers().FirstOrDefault(u => u.Email.Equals(UsernameInput.Text) && u.Password.Equals(PasswordInput.Text));
            if (user != null)
            {
                loggedInUser = user;
                this.Close();
                PasswordInput.ResetText();
                UsernameInput.ResetText();
            }
            else
            {
                MessageBox.Show("No such user");
            }
        }

        public User GetUser()
        {
            return loggedInUser;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CheckPassword();
            counter = counter + 1;
        }

        private void pbSeeImage_Click(object sender, EventArgs e)
        {
            counter = 0;
            Timer.Start();
        }
        private void CheckPassword()
        {
            if (counter < 30)
            {
                PasswordInput.UseSystemPasswordChar = true;
            }
            else
            {
                PasswordInput.UseSystemPasswordChar = false;
                Timer.Stop();
                counter = 0;
            }
        }        
    }
}