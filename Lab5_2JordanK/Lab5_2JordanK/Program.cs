using System;
using System.Collections.Generic;

namespace Lab5_2JordanK
{
    class Program
    {

        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            //List to Hold Tasks
            List<string> taskList = new List<string>();
            
            //foreach loop
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine("Enter a new task for " + day);
                string task = day + ": " + Console.ReadLine();
                taskList.Add(task);
            }

            //print all of the tasks
            foreach (string task in taskList)
            {
                Console.WriteLine(task);
            }
        }
    }
}
