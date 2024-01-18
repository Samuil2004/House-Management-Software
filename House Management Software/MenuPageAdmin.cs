using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace House_Management_Software
{
    public partial class MenuPageAdmin : Form
    {
        private bool close_application;
        User loggedInUser;
        MenuPage menupage;
        public MenuPageAdmin(MenuPage menupage, User loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            this.menupage = menupage;
            close_application = true;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void SeeComlainsButton_Click(object sender, EventArgs e)
        {
            ComplainsPageForAdmins complainsPageForAdmins = new ComplainsPageForAdmins(this);
            this.Hide();
            complainsPageForAdmins.ShowDialog();
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

        private void AllUsersButton_Click(object sender, EventArgs e)
        {
            AllUsersPage allUsersPage = new AllUsersPage(this, loggedInUser);
            this.Hide();
            allUsersPage.ShowDialog();
        }

        private void btTasks_Click(object sender, EventArgs e)
        {
            TasksAdmin tasksAdmin = new TasksAdmin(this);
            this.Hide();
            tasksAdmin.ShowDialog();
        }

        private void SeeEventsButton_Click(object sender, EventArgs e)
        {
            EventsFromAdminSide eventsFromAdminSide = new EventsFromAdminSide(this);
            this.Hide();
            eventsFromAdminSide.ShowDialog();
        }

        private void pbUserIcon_Click(object sender, EventArgs e)
        {
            InfoUserA infoUserA = new InfoUserA(loggedInUser, this);
            this.Hide();
            infoUserA.ShowDialog();
        }

        private void pbLogOut_Click(object sender, EventArgs e)
        {
            close_application = true;
            this.Close();
        }
    }
}
