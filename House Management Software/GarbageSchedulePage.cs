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
    public partial class GarbageSchedulePage : Form
    {
        MenuPage menuPage;
        GarbageManager garbageManager;
        private bool close_application;

        public GarbageSchedulePage(MenuPage menuPage, User loggenInUser)
        {
            InitializeComponent();
            this.garbageManager = new GarbageManager(loggenInUser);
            this.menuPage = menuPage;

            garbageManager.ExtractFromFile();
            close_application = true;

            AddInformationLabels();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            garbageManager.InsertIntoFile();
            close_application = false;
            this.Close();
            menuPage.Show();
        }
        private void AddInformationLabels()
        {
            DateLabelPaper.Text = garbageManager.ChangeDateLabel("Paper");
            DateBioLabel.Text = garbageManager.ChangeDateLabel("Bio");
            DateLabelResidual.Text = garbageManager.ChangeDateLabel("Residual");

            PersonPaperLabel.Text = garbageManager.ChangeTextLabel("Paper");
            PersonBioLabel.Text = garbageManager.ChangeTextLabel("Bio");
            PersonResidualLabel.Text = garbageManager.ChangeTextLabel("Residual");
        }
        private void AnyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close_application)
            {
                garbageManager.InsertIntoFile();
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
