using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5JordanK
{
    class HouseHunters : Application
    {
            private string jobTitle;
            private int currentAnnualIncome;
            private string whenWillYouLookForAHouse;
            private int numOfBedrooms;
            private int numofBathrooms;

        public HouseHunters(string jobTitle, int currentAnnualIncome, string whenWillYouLookForAHouse, int numOfBedrooms, int numofBathrooms, 
            string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zipcode, 
            string phoneNumber, string emailAddress) : base(firstName, lastName, dateOfBirth, address,
                city, state, zipcode, phoneNumber, emailAddress)
        {
            this.jobTitle = jobTitle;
            this.currentAnnualIncome = currentAnnualIncome;
            this.whenWillYouLookForAHouse = whenWillYouLookForAHouse;
            this.numOfBedrooms = numOfBedrooms;
            this.numofBathrooms = numofBathrooms;
        }

        public override void Accept()
            {
                base.Accept();
                Console.WriteLine("Your Application was accepted by \"Dream House Hunters.\"");
            }
     
    }
}
