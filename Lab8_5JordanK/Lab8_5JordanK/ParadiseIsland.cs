using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5JordanK
{
    class ParadiseIsland : Application
    {
            private string gender;
            private string nameOfPartner;
            private int numOfYearsDating;

        public ParadiseIsland(string gender, string nameOfPartner, int numOfYearsDating, string firstName, string lastName, string dateOfBirth, string address,
            string city, string state, int zipcode, string phoneNumber, string emailAddress) : base(firstName, lastName, dateOfBirth, address,
                city, state, zipcode, phoneNumber, emailAddress)
        {
            this.gender = gender;
            this.nameOfPartner = nameOfPartner;
            this.numOfYearsDating = numOfYearsDating;
        }

            public override void Accept()
            {
                base.Accept();
                Console.WriteLine("Your Application was accepted by \"Paradise Island\"");
            }
     
    }
}
