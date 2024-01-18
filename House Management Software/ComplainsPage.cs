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
    public partial class ComplainsPage : Form
    {
        MenuPage menuPage;
        User loggedInUser;
        ComplainsManager complainsManager;
        private bool close_application;

        public ComplainsPage(MenuPage menuPage, User loggedInUser)
        {
            InitializeComponent();
            this.menuPage = menuPage;
            this.loggedInUser = loggedInUser;
            TopLabel.Text = $"{loggedInUser.FirstName}, Please share with use if anything borthers you!";
            foreach (complainCategories comlaintype in Enum.GetValues(typeof(complainCategories)))
            {
                cbComplainCategory.Items.Add(comlaintype);
            }
            tbComplainsDescription.Enabled = false;
            SubmitComlainButton.Enabled = false;
            complainsManager = new ComplainsManager();
            close_application = true;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void SubmitComlainButton_Click(object sender, EventArgs e)
        {
            complainCategories selectedCmplainType = (complainCategories)Enum.Parse(typeof(complainCategories), cbComplainCategory.SelectedItem.ToString());
            string info = complainsManager.AddComplain(selectedCmplainType, tbComplainsDescription.Text).GetInfo;
            complainsManager.SerializeToFiles(complainsManager.AddComplain(selectedCmplainType, tbComplainsDescription.Text));
            MessageBox.Show("Serialized successfully");
            cbComplainCategory.ResetText();
            tbComplainsDescription.ResetText();
        }

        private void pbBackToMenuButton_Click(object sender, EventArgs e)
        {
            menuPage.Show();
            close_application = false;
            this.Close();
        }

        private void cbComplainCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbComplainsDescription.Enabled = true;
        }

        private void tbComplainsDescription_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbComplainsDescription.Text))
            {
                SubmitComlainButton.Enabled = true;
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
