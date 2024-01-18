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
    public partial class AllUsersPage : Form
    {
        DataManager dataManager;
        MenuPageAdmin menuPageAdmin;
        User loggedInUser;
        private bool close_application;
        public AllUsersPage(MenuPageAdmin menuPageAdmin,User loggedInUser)
        {
            InitializeComponent();
            dataManager = new DataManager();
            this.menuPageAdmin = menuPageAdmin;
            this.loggedInUser = loggedInUser;
            close_application = true;
            RefreshPage();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        public void RefreshPage()
        {
            tbSelectedStudentInfo.ResetText();
            lbAllUsers.Items.Clear();
            foreach (User user in dataManager.GetUsers())
            {
                lbAllUsers.Items.Add(user.GetInfoForAdmin);
            }
        }
        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            menuPageAdmin.Show();
            close_application = false;
            this.Close();
        }

        private void lbAllUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAllUsers.SelectedItem != null)
            {
                tbSelectedStudentInfo.Text = dataManager.GetUser(lbAllUsers.SelectedItem.ToString()).DetailedInfoForStudent;
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

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if(lbAllUsers.SelectedItem !=null)
            {
                MessageBox.Show(dataManager.DeteleUser(lbAllUsers.SelectedItem.ToString(),loggedInUser));
                RefreshPage();
            }
        }
    }
}
