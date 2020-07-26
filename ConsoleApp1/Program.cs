using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s1 = "Hello!";
            string s2 = s1; //hello
            s1 += "world";
            Console.WriteLine(s2);

            //string myfile
            string myfile = @"c:\documents\files\123.txt";
            Console.WriteLine(myfile);

	        string key = "some text \n more text on new line";
            Console.WriteLine(key);

            string key1 = @"some text \n more text on new line";
            Console.WriteLine(key1);

            string name = "Mark";
            var date = DateTime.Now;

            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now,", name, date.DayOfWeek, date);

            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date}");
        }
    }
}
