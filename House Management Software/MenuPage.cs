using CsvHelper.Configuration.Attributes;
using Microsoft.VisualBasic.Logging;
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
    public partial class MenuPage : Form
    {
        private User loggedInUser;
        ProductsManager productsManager;
        LogIn logIn;
        private int login_index = 0;

        public MenuPage()
        {
            logIn = new LogIn();
            productsManager = new ProductsManager();
            InitializeComponent();
            Load += MenuPage_Load;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        public void CheckForAdmin()
        {
            if (loggedInUser.Status.Equals("admin"))
            {
                MenuPageAdmin menuPageAdmin = new MenuPageAdmin(this,loggedInUser);
                this.Hide();
                menuPageAdmin.ShowDialog();
            }
        }
        private void MenuPage_Load(object sender, EventArgs e)
        {
            if (loggedInUser == null && login_index == 0)
            {
                logIn.ShowDialog();
                loggedInUser = logIn.GetUser();
            }
            else if (login_index > 0 && loggedInUser == null)
            {
                this.Close();
            }
            else
            {
                CheckForAdmin();
            }
            login_index++;
        }

        private void RulesButton_Click(object sender, EventArgs e)
        {
            RulesPage rulesPage = new RulesPage(loggedInUser, this);
            this.Hide();
            rulesPage.Show();
        }

        private void GroceryListButton_Click(object sender, EventArgs e)
        {
            GroceryList groceryList = new GroceryList(loggedInUser, this, productsManager);
            this.Hide();
            groceryList.Show();
        }

        private void TasksButton_Click_1(object sender, EventArgs e)
        {
            TasksPage tasksPage = new TasksPage(this,loggedInUser);
            this.Hide();
            tasksPage.Show();
        }

        private void GarbageScheduleButton_Click(object sender, EventArgs e)
        {
            GarbageSchedulePage garbageSchedulePage = new GarbageSchedulePage(this, loggedInUser);
            this.Hide();
            garbageSchedulePage.Show();
        }

        private void pbUserIcon_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile(loggedInUser,this);
            this.Hide();
            userProfile.Show();
        }

        public void pbLogOut_Click(object sender, EventArgs e)
        {
            loggedInUser = null;
            LogIn newLogIn = new LogIn();
            this.Hide();
            newLogIn.ShowDialog();
            loggedInUser = newLogIn.GetUser();
            if (loggedInUser != null && loggedInUser.Status.Equals("admin"))
            {
                MenuPageAdmin menuPageAdmin = new MenuPageAdmin(this, loggedInUser);
                menuPageAdmin.ShowDialog();
                this.Show();
                loggedInUser = null;
                //MenuPage_Load;
            }
            else if (loggedInUser != null)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void ComplainsButton_Click(object sender, EventArgs e)
        {
            ComplainsPage complains = new ComplainsPage(this, loggedInUser);
            complains.Show();
            this.Hide();
        }

        private void EventButton_Click(object sender, EventArgs e)
        {
            EventPage eventPage = new EventPage(this,loggedInUser);
            eventPage.Show();
            this.Hide();
        }
    }
}
