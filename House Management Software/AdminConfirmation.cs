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
    public partial class AdminConfirmation : Form
    {
        InfoUserA infoUserA;
        User loggedInUser;
        DataManager dataManager;
        private string newUsername;
        private string newPhoneNumber;
        private string newPassword;
        private bool close_application;

        public AdminConfirmation(User loggedInUser, InfoUserA infoUserA, DataManager dataManager, string username, string phoneNumber, string password)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            this.infoUserA = infoUserA;
            this.newUsername = username;
            this.newPhoneNumber = phoneNumber;
            this.newPassword = password;
            this.dataManager = dataManager;
            listBoxPrinter(loggedInUser, username, phoneNumber, password);
            close_application = true;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        public void listBoxPrinter(User loggedInUser, string username, string phoneNumber, string password)
        {
            lbChangedData.Items.Clear();
            lbChangedData.DrawMode = DrawMode.OwnerDrawFixed;
            lbChangedData.DrawItem += listBox1_DrawItem;
            if (!loggedInUser.Email.Equals(username))
            {
                lbChangedData.Items.Add($"{loggedInUser.Email} -> {username}");
            }
            if (!loggedInUser.PhoneNumber.Equals(phoneNumber))
            {
                lbChangedData.Items.Add($"{loggedInUser.PhoneNumber} -> {phoneNumber}");
            }
            if (!loggedInUser.Password.Equals(password))
            {
                lbChangedData.Items.Add($"{loggedInUser.Password} -> {password}");
            }
        }
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            
            loggedInUser.Email = newUsername;
            loggedInUser.PhoneNumber = newPhoneNumber;
            loggedInUser.Password = newPassword;
            dataManager.ApplyChangedToProfileCredentials(loggedInUser, newUsername, newPhoneNumber, newPassword);
            MessageBox.Show("Changes have been applies sucessfully");
            close_application = false;
            this.Close();
            infoUserA.Refresh();
            infoUserA.Show();
        }

        private void DenyButton_Click(object sender, EventArgs e)
        {
            close_application = false;
            this.Close();
            infoUserA.Show();
        }
        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;
            e.DrawBackground();
            ListBox listBox = (ListBox)sender;
            string itemText = listBox.Items[e.Index].ToString();
            Font font = listBox.Font;
            Brush brush = new SolidBrush(listBox.ForeColor);
            float y = e.Bounds.Top + (e.Bounds.Height - e.Font.Height) / 2;
            e.Graphics.DrawString(itemText, font, brush, e.Bounds.Left, y);
            brush.Dispose();
            e.DrawFocusRectangle();
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
