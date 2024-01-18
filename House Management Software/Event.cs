using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace House_Management_Software
{
    public class Event
    {
        private int id;
        private string title;
        private string description;
        private DateTime dateTime;
        private User student;

        public Event(int id,string title, string description, DateTime dateTime, User student)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.dateTime = dateTime;
            this.student = student;
        }

        public string GetInfo
        {
            get { return $"{this.dateTime} - {this.title}"; }
        }

        public string GetDetailedInfo
        {
            get { return $"Name: {title}\r\n Description: {description}\r\n Date & Time: {dateTime}\r\n Announced by: {student.Email}\r\n Apartment: {student.ApartmentNumber}"; }
        }

        public string GetInfoAdmin
        {
            get { return $"{student.ApartmentNumber} - {this.dateTime} - {this.title}"; }
        }

        public string GetTitle
        {
            get { return title; }
        }
        public string GetDescription
        {
            get { return description; }
        }
        public DateTime GetDateTime
        {
            get { return dateTime; }
        }
        public User GetStudent 
        { 
            get { return student; }
        }
        public int GetId
        {
            get { return id; }
        }
    }
}
