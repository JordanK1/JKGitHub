using System;

namespace Lab4_6JordanK
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] tasks = new string[7];

            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine("The Task for " + dayOfTheWeek[i]);
                tasks[i] = dayOfTheWeek[i] + ": " + Console.ReadLine();
            }

            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine(tasks[i]);
            }


        }
    }
}
