using System;

namespace Inclass_Test
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

            string color1 = "red";
            string color2 = "yellow";
            Console.WriteLine($"Roses are {color1}, Sunflowers are {color2}.");

            string Line1 = "myemailaddress@yahoo.com";
            Console.WriteLine(Line1.IndexOf("@"));
            Console.WriteLine(Line1.IndexOf("address"));
            Console.WriteLine(Line1.IndexOf("gmail"));

            string Line2 = "The cat in the corner can count.";
            Console.WriteLine(Line2.Replace("c", "z"));
            Console.WriteLine(Line2);
            Console.WriteLine(Line2.Length);
            Console.WriteLine(Line2.Contains("in the"));

            string[] words = Line2.Split("z");

            foreach(string word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine(Line2.Substring(8, 4));

            string Line3 = "        TRIM ME DOWN            ";
            Console.WriteLine(Line3.Trim());
            Console.WriteLine(Line3.ToLower());
            Console.WriteLine(Line3.GetType());
            Console.WriteLine(Line2.Remove(6));
        }
    }
}
