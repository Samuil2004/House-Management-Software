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
    public partial class EventPage : Form
    {
        MenuPage menuPage;
        User loggedInUser;
        EventManager eventManager;
        private bool close_application;
        public EventPage(MenuPage menuPage, User loggedInUser)
        {
            InitializeComponent();
            this.menuPage = menuPage;
            this.loggedInUser = loggedInUser;
            eventManager = new EventManager();
            AddEventButton.Enabled = false;
            tbDescriptionOfEvent.Enabled = false;
            DatePicker.Enabled = false;
            RefreshPage();
            DatePicker.MinDate = DateTime.Today.AddDays(1);
            close_application = true;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            close_application = false;
            this.Close();
            menuPage.Show();
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbDescriptionOfEvent.Text) && !string.IsNullOrEmpty(tbTitleOfEvent.Text))
            {
                eventManager.CreateEvent(tbTitleOfEvent.Text, tbDescriptionOfEvent.Text, DatePicker.Value, loggedInUser);
                MessageBox.Show(eventManager.GetInfo());
                RefreshPage();
            }
        }

        public void RefreshPage()
        {
            tbTitleOfEvent.ResetText();
            tbDescriptionOfEvent.ResetText();
            DatePicker.ResetText();
            tbInfoForEvent.ResetText();
            lbAllEvents.Items.Clear();
            foreach (Event evEnt in eventManager.GetEvents(loggedInUser))
            {
                lbAllEvents.Items.Add(evEnt.GetInfo);
            }
        }

        private void tbTitleOfEvent_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbTitleOfEvent.Text))
            {
                tbDescriptionOfEvent.Enabled = true;
            }
        }

        private void tbDescriptionOfEvent_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbDescriptionOfEvent.Text))
            {
                DatePicker.Enabled = true;
                AddEventButton.Enabled = true;
            }
            else
            {
                DatePicker.Enabled = false;
                AddEventButton.Enabled = false;
            }
        }

        private void lbAllEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAllEvents.SelectedItem != null)
            {
                Event selectedEvent = eventManager.GetEvents(loggedInUser).FirstOrDefault(selectedEvent => selectedEvent.GetInfo.Equals(lbAllEvents.Text));
                tbInfoForEvent.Text = selectedEvent.GetDetailedInfo;
            }
        }

        private void CancelEventButton_Click(object sender, EventArgs e)
        {
            if (lbAllEvents.SelectedItem != null)
            {
                Event selectedEvent = eventManager.GetEvents(loggedInUser).FirstOrDefault(selectedEvent => selectedEvent.GetInfo.Equals(lbAllEvents.Text));
                if (selectedEvent.GetStudent.Email.Equals(loggedInUser.Email))
                {
                    eventManager.CancelEvent(selectedEvent);
                    RefreshPage();
                }
                else
                {
                    MessageBox.Show("You can not delete your housemate's events");
                }
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
