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
    public partial class EventsFromAdminSide : Form
    {
        MenuPageAdmin menuPageAdmin;
        EventManager eventManager;
        private bool close_application;
        public EventsFromAdminSide(MenuPageAdmin menuPageAdmin)
        {
            InitializeComponent();
            this.menuPageAdmin = menuPageAdmin;
            eventManager = new EventManager();
            RefreshPage();

            close_application = true;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            close_application = false;
            this.Close();
            menuPageAdmin.Show();
        }

        public void RefreshPage()
        {
            lbAllEvents.Items.Clear();
            foreach (Event eVent in eventManager.GetEventsForAdmin())
            {
                lbAllEvents.Items.Add(eVent.GetInfoAdmin);
            }
            tbInfoForEvent.ResetText();
        }

        private void lbAllEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbAllEvents.SelectedItem != null)
            {
                Event selectedEvent = eventManager.GetEventsForAdmin().FirstOrDefault(selectedEvent => selectedEvent.GetInfoAdmin.Equals(lbAllEvents.Text));
                tbInfoForEvent.Text = selectedEvent.GetDetailedInfo;
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
