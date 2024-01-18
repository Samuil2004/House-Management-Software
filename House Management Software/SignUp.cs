using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CsvHelper;
using System.Reflection;
using System.DirectoryServices;
using System.Diagnostics.Eventing.Reader;

namespace House_Management_Software
{

    public partial class SignUp : Form
    {
        DataManager dataManager;
        LogIn logIn;
        private int counter;
        private bool close_application;
        public SignUp(LogIn logIn)
        {
            InitializeComponent();
            dataManager = new DataManager();
            this.logIn = logIn;
            RefreshPage();
            close_application = true;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        public void RefreshPage()
        {
            PasswordInput.Text = "";
            PasswordInput.PasswordChar = '*';
            ConfirmPasswordInput.Text = "";
            ConfirmPasswordInput.PasswordChar = '*';
            FirstNameInput.ResetText();
            LastNameInput.ResetText();
            EmailAdressInput.ResetText();
            PhoneNumberInput.ResetText();
            ApartmentNumberInput.ResetText();
            ApartmentCodeInput.ResetText();
            PasswordInput.ResetText();
            ConfirmPasswordInput.ResetText();
        }

        private void ToLogInPage_Click(object sender, EventArgs e)
        {
            close_application = false;
            this.Close();
            logIn.RefreshPage();
            logIn.Show();
        }

        private void SignUpSubmitButton_Click(object sender, EventArgs e)
        {
            string returnedString = dataManager.SignUpPageDataManager(FirstNameInput.Text, LastNameInput.Text, EmailAdressInput.Text, PhoneNumberInput.Text, ApartmentNumberInput.Text, ApartmentCodeInput.Text, PasswordInput.Text, ConfirmPasswordInput.Text, "student");
            if (returnedString.Equals("add"))
            {
                close_application = false;
                this.Hide();
                logIn.RefreshPage();
                logIn.Show();
                MessageBox.Show("You have been sucessfully registered.\nYou can now easily log in!");
            }
            else if (!returnedString.Equals("add"))
            {
                MessageBox.Show(returnedString);
            }
        }

        private void pbSeeImage_Click(object sender, EventArgs e)
        {
            Timer.Start();
            counter = 0;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CheckPassword();
            counter = counter + 1;
        }
        private void CheckPassword()
        {
            if (counter < 6)
            {
                PasswordInput.UseSystemPasswordChar = true;
                ConfirmPasswordInput.UseSystemPasswordChar = true;
            }
            else
            {
                PasswordInput.UseSystemPasswordChar = false;
                ConfirmPasswordInput.UseSystemPasswordChar = false;
                Timer.Stop();
                counter = 0;
            }
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
