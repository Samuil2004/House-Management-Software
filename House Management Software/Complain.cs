using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace House_Management_Software
{
    [Serializable]
    public class Complain
    {
        private complainCategories category;
        private string description;
        private DateTime dateTime;

        public Complain(DateTime dateTime, complainCategories Category, string Description)
        {
            this.dateTime = dateTime;
            this.category = Category;
            this.description = Description;
        }

        public string GetInfo
        {
            get { return $"{this.dateTime} - {this.category} - {this.description}"; }
        }
    }
}