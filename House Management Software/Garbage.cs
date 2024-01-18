using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Management_Software
{
    public class Garbage
    {
        private User user;
        private string category;
        private DateTime date;

        public Garbage(User user, string category, DateTime date)
        {
            this.User = user;
            this.Category = category;
            this.Date = date;
        }

        public User User
        {
            get { return user; }
            set { user = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
    }
}
