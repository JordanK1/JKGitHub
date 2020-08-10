using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5JordanK
{
    class Application
    {
     
        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private string address;
        private string city;
        private string state;
        private int zipcode;
        private string phoneNumber;
        private string emailAddress;
        private bool appSubmitted;
        private bool appAccepted;

        public Application(string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zipcode,
                string phoneNumber, string emailAddress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
            appSubmitted = false;
            appAccepted = false;
        }

        public void Submit()
            {
                Console.WriteLine("Application has been submitted.");
                appSubmitted = true;
            }

        public virtual void Accept()
            {
                appAccepted = true;
                Console.WriteLine("Application has been accepted.");
            }
      
    }
}
