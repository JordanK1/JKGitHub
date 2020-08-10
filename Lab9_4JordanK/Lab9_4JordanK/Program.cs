using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab9_4JordanK
{
    class Program
    { 
        static void Main(string[] args)
        {
            const string logFile = "J://lab9-4.html";

            StringBuilder htmlLab = new StringBuilder(); //Building the components
            string bodyOpen = "<body>";
            string bodyClose = "</body>";
            string h1Open = "<h1>";
            string h1Close = "</h1>";
            string ulOpen = "<ul>";
            string ulClose = "</ul>";
            string listOpen = "<li>";
            string listClose = "</li>";
            Console.WriteLine("Enter text for HTML header");
            string dynamicHTML = Console.ReadLine();

            //start of the html
            htmlLab.Append(bodyOpen);
            htmlLab.Append(h1Open);
            htmlLab.Append(dynamicHTML);
            htmlLab.Append(h1Close);

            //unordered list
            htmlLab.Append(ulOpen);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Add another item to the list.");
                htmlLab.Append(listOpen);
                string dynamicHTML2 = Console.ReadLine();
                htmlLab.Append(dynamicHTML2);
                htmlLab.Append(listClose);
            }
            htmlLab.Append(ulClose);

            htmlLab.Append(bodyClose);
            File.AppendAllText(logFile, htmlLab.ToString());

        }
    }
}
