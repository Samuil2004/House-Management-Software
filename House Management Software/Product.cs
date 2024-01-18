using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Management_Software
{
    public class Product
    {
        private int id;
        private string name;
        private int amount;
        private string description;
        private bool status;
        private int apartmentNumber;

        public Product(int Id, string Name, int Amount,bool status,int apartmentNumber)
        {
            this.id = Id;
            this.name = Name;
            this.amount = Amount;
            this.apartmentNumber = apartmentNumber;
        }

        public string GetInfo
        {
            get
            {
                if (!this.description.Equals(""))
                {
                    return $"{this.amount} x {this.name} - {this.description}";
                }
                else
                {
                    return $"{this.amount} x {this.name}";
                }
            }
        }

        public string Description
        {
            set { description = value; }
            get { return description; }
        }

        public int GetId
        {
            get { return id; }
        }

        public bool GetStatus
        {
            get { return status; }
        }

        public void ChangeProductStatus()
        {
            this.status = true;
        }
        public string GetName
        {
            get { return name; }
        }

        public int GetAmount
        {
            get { return amount; }
        }
        public int ApartmentNumber
        {
            get { return apartmentNumber; }
        }
    }
}
