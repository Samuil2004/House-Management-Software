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
    public partial class ComplainsPageForAdmins : Form
    {
        ComplainsManager complainManager;
        private bool close_application;
        MenuPageAdmin menuPageAdmin;

        public ComplainsPageForAdmins(MenuPageAdmin menuPageAdmin)
        {
            InitializeComponent();
            complainManager = new ComplainsManager();
            close_application = true;
            this.menuPageAdmin = menuPageAdmin;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            List<Complain> allComplains = complainManager.DeserializeFromFile();
            if (allComplains != null)
            {
                lbComplains.Items.Clear();
                foreach (Complain complain in allComplains)
                {
                    lbComplains.Items.Add(complain.GetInfo);
                }
            }
            else
            {
                MessageBox.Show("List is null");
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

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            close_application = false;
            menuPageAdmin.Show();
            this.Close();
        }
    }
}
