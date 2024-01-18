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
    public partial class RulesPage : Form
    {
        User newUser;
        MenuPage menuPage;
        private bool close_application;
        public RulesPage(User user, MenuPage menuPage)
        {
            InitializeComponent();
            this.newUser = user;
            this.menuPage = menuPage;
            TitleLabel.Text = $"{user.FirstName}, please consider the following rules:";
            close_application = true;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            close_application = false;
            this.Close();
            menuPage.Show();
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
