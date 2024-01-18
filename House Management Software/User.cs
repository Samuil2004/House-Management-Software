using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Management_Software
{
    public class User
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private int apartmentNumber;
        private int apartmentCode;
        private string password;
        private string status;

        public User(int Id,string FirstName, string LastName, string Status) 
        {
            this.id = Id;
            this.firstName = FirstName;
            this.lastName = LastName;
            this.status = Status;
        }

        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public int ApartmentNumber
        {
            get { return apartmentNumber; }
            set { apartmentNumber = value; }
        }
        public int ApartmentCode
        {
            get { return apartmentCode; }
            set { apartmentCode = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Status
        {
            get { return status; }
        }
        public int Id
        {
            get { return id; }
        }
        public string GetFirstandLastName
        {
            get { return $"{this.firstName} {this.lastName}"; }
        }
        public string GetInfoForAdmin
        {
            get { return $"{this.apartmentNumber} - {this.firstName} {this.lastName}"; }
        }
        public string DetailedInfoForStudent
        {
            get { return $"Id: {id}\r\n Name: {firstName} {lastName}\r\n Email: {email}\r\n Phone Number: {phoneNumber}\r\n Aparment: {apartmentNumber}\r\n "; }
        }
    }
}
