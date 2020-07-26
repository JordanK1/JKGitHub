using System;
using System.Collections;

namespace Lab4_5JordanK
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList hiScores = new ArrayList(); //1: Creating the ArrayList
            hiScores.Add(4400);
            hiScores.Add(8900);
            hiScores.Add(1200);
            hiScores.Add(3700);
            hiScores.Add(7200);

            Console.WriteLine("Listing Out All the Values:");
            foreach (int item in hiScores)
            {
                Console.WriteLine(item);
            };


            //2: Sort Low to High
            Console.WriteLine("Sorting From Low To High:");
            hiScores.Sort();

            foreach (int item in hiScores)
            {
                Console.WriteLine(item);
            };

            //3: Sort High to Low
            Console.WriteLine("Sorting From High To Low:");
            hiScores.Reverse();

            foreach (int item in hiScores)
            {
                Console.WriteLine(item);
            };

            //4: Add a New Score
            hiScores.Add(2400);

            //5: Remove a Score
            hiScores.Remove(4400);

            Console.WriteLine("Final Check:");
            hiScores.Sort();

            foreach (int item in hiScores)
            {
                Console.WriteLine(item);
            };
        }
    }
}
