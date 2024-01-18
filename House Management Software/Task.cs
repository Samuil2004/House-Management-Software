using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Management_Software
{
    public class Task
    {
        private int id;
        private taskCategories category;
        private string taskDescription;
        private DateTime DateTime;
        private bool status;
        private User AssignedTo;
        private int studentRoomNumber;
        public Task(int id,taskCategories Category, string TaskDescription, DateTime dateTime, bool Status, User AssignedTo, int StudentRoomNumber)
        {
            this.id = id;
            this.category = Category;
            this.taskDescription = TaskDescription;
            this.DateTime = dateTime;
            this.status = Status;
            this.AssignedTo = AssignedTo;
            this.studentRoomNumber = StudentRoomNumber;
        }
        public void ChangeStatus()
        {
            this.status = true;
        }
        
        public int GetId
        {
            get { return this.id; }
        }

        public string CompletedOrNot
        {
            get
            {
                if (this.status)
                {
                    return "Completed";
                }
                else
                {
                    return "Incompleted";
                }
            }
        }

        public int StudentRoomNumber
        {
            get
            {
                return this.studentRoomNumber;
            }
        }

        public string TaskAllInfoAdmin
        {
            get
            {
                return $" {this.AssignedTo.GetFirstandLastName} - {this.DateTime.ToString("yyyy-MM-dd")} - {this.DayOfWeek} - {this.category}";
            }
        }
        public string TaskForCalendar
        {
            get
            {
                return $"{this.category} - {this.AssignedTo.FirstName} - {CompletedOrNot}";
            }
        }
        public string GetDetailedInfo
        {
            get { return $"Category: {category}\r\n Description: {taskDescription}\r\n Date & Time: {DateTime.ToString("yyyy-MM-dd")}\r\n Assigned to: {AssignedTo.Email}\r\n Apartment: {studentRoomNumber}"; }
        }

        public string TaskDescription
        {
            get
            {
                if (string.IsNullOrEmpty(this.taskDescription))
                {
                    this.taskDescription = "Nothing here";
                }
                return this.taskDescription;
            }
        }

        public DateTime GetDate
        {
            get { return this.DateTime; }
        }

        public string DayOfWeek
        {
            get
            {
                string day = this.GetDate.ToString("dddd");
                return day;
            }
        }

        public User GetUser
        {
            get { return this.AssignedTo; }
        }
         
        public taskCategories GetCategory
        {
            get { return category; }
        }

        public bool GetStatus
        {
            get { return this.status; }
        }
    }
}
