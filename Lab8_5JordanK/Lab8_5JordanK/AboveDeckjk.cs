using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5JordanK
{
    class AboveDeckjk : Application
    {
     
        private int yearsOfBoatExp;
        private string nationality;

        public AboveDeckjk(int yearsOfBoatExp, string nationality, 
            string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zipcode, string phoneNumber, string emailAddress) 
            : base(firstName, lastName, dateOfBirth, address, city, state, zipcode, phoneNumber, emailAddress)
        {
            this.yearsOfBoatExp = yearsOfBoatExp;
            this.nationality = nationality;
        }

        public override void Accept()
            {
                base.Accept();
                Console.WriteLine("Your Application was accepted by \"Above Deck\"");
            }
        
    }
}
