using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Management_Software
{
    public partial class InfoUserA : Form
    {
        MenuPageAdmin MenuPageAdmin;
        User loggedInUser;
        DataManager dataManager;
        private int counter;
        private bool close_application;
        public InfoUserA(User loggedInUSer, MenuPageAdmin menuPageAdmin)
        {
            InitializeComponent();
            this.MenuPageAdmin = menuPageAdmin;
            this.loggedInUser = loggedInUSer;
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

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            close_application = false;
            this.Hide();
            MenuPageAdmin.Show();
        }

        private void pbSeeImage_Click(object sender, EventArgs e)
        {
            counter = 0;
            Timer.Start();
        }

        private void CheckPassword()
        {
            if (counter < 6)
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
        private void ChangeButton_Click_1(object sender, EventArgs e)
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
                                    AdminConfirmation adminConfirmation = new AdminConfirmation(loggedInUser, this, dataManager, tbUsername.Text, tbPhoneNumber.Text, tbPassword.Text);
                                    this.Hide();
                                    adminConfirmation.ShowDialog();
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
                        AdminConfirmation adminConfirmation = new AdminConfirmation(loggedInUser, this, dataManager, tbUsername.Text, tbPhoneNumber.Text, tbPassword.Text);
                        this.Hide();
                        adminConfirmation.ShowDialog();
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            CheckPassword();
            counter = counter + 1;
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
