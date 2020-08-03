using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6Exercises
{
    class Animal
    {
        private int legs { get; set; }
        private int arms { get; set; }
        private string type { get; set; }
        private string name { get; set; }
        private bool dangerous { get; set; }


        public Animal(int legs, int arms, string type, string name, bool dangerous)
        {
            this.legs = legs;
            this.arms = arms;
            this.type = type;
            this.name = name;
            this.dangerous = dangerous;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Type of Animal: " + type);
            Console.WriteLine("Number of Arms: " + arms);
            Console.WriteLine("Number of Legs: " + legs);
            Console.WriteLine("Is it Dangerous? " + dangerous);
        }

        public void SendToObedienceSchool()
        {
            if (this.dangerous == true)
            {
                dangerous = false;
                Console.WriteLine(this.name + " is a good " + this.type + " now!");
            }
            else
            {
                Console.WriteLine("But " + this.name + " isn't dangerous!");
            }
        }
    }
}
