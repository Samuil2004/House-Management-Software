using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Management_Software
{
    public partial class UserProfile : Form
    {
        User loggedInUser;
        MenuPage menuPage;
        DataManager dataManager;
        private int counter;
        private bool close_application;
        public UserProfile(User loggedInUser,MenuPage menuPage)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            this.menuPage = menuPage;
            dataManager = new DataManager();
            Refresh();
            tbConfirmPassword.ResetText();
            tbPassword.Text = "";
            tbPassword.PasswordChar = '*';
            tbConfirmPassword.Text = "";
            tbConfirmPassword.PasswordChar = '*';
            close_application = true;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        
        public void Refresh()
        {
            tbPassword.ResetText();
            tbConfirmPassword.ResetText();
            tbUsername.ResetText();
            tbPhoneNumber.ResetText();
            tbConfirmPassword.ResetText();
            UserFLNameLabel.Text = loggedInUser.FirstName + " " + loggedInUser.LastName;
            tbUsername.Text = loggedInUser.Email;
            tbPhoneNumber.Text = loggedInUser.PhoneNumber;
            ApartLabel.Text = $"Apart. {loggedInUser.ApartmentNumber}";
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            close_application = false;
            this.Close();
            menuPage.Show();
        }

        public string UserNameChecker(string username)
        {
            if (!loggedInUser.Email.Equals(username))
            {
                foreach (User user in dataManager.GetUsers())
                {
                    if (user.Email.Equals(username))
                    {
                        return "Email is already used";
                    }
                }
                if (!username.Contains('@'))
                {
                    return "Invalid Email Adress";
                }
                return null;
            }
            return null;
        }


        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (!tbUsername.Text.Equals(loggedInUser.Email) || !tbPhoneNumber.Text.Equals(loggedInUser.PhoneNumber) || !tbPassword.Text.Equals(loggedInUser.Password))
            {
                if (UserNameChecker(tbUsername.Text) == null)
                {
                    if (!tbPassword.Text.Equals(loggedInUser.Password))
                    {
                        if (dataManager.PasswordChecker(tbPassword.Text).Equals("add"))
                        {
                            if (!string.IsNullOrEmpty(tbConfirmPassword.Text))
                            {
                                if (tbPassword.Text.Equals(tbConfirmPassword.Text))
                                {
                                    ChangesConfirmationPage changesConfirmationPage = new ChangesConfirmationPage(loggedInUser, this, dataManager, tbUsername.Text, tbPhoneNumber.Text, tbPassword.Text);
                                    this.Hide();
                                    changesConfirmationPage.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Passwords do not match");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please confirm the password");
                            }
                        }
                        else
                        {
                            MessageBox.Show(dataManager.PasswordChecker(tbPassword.Text));
                        }
                    }
                    else
                    {
                        ChangesConfirmationPage changesConfirmationPage = new ChangesConfirmationPage(loggedInUser, this, dataManager, tbUsername.Text, tbPhoneNumber.Text, tbPassword.Text);
                        this.Hide();
                        changesConfirmationPage.Show();
                    }
                }
                else
                {
                    MessageBox.Show(UserNameChecker(tbUsername.Text));
                }
            }
            else
            {
                MessageBox.Show("No changes have been applied");
            }
        }
        private void pbSeeImage_Click(object sender, EventArgs e)
        {
            counter = 0;
            Timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            CheckPassword();
            counter = counter + 1;
        }
        private void CheckPassword()
        {
            if(counter < 6)
            {
                tbPassword.UseSystemPasswordChar = true;
                tbConfirmPassword.UseSystemPasswordChar = true;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = false;
                tbConfirmPassword.UseSystemPasswordChar = false;
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
