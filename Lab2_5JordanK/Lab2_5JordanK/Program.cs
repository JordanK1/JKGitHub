using System;

namespace Lab2_5JordanK
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lab2_5
            //1: Add Numbers
            int num1; //blank input for first number
            int num2; //blank input for second number

            Console.WriteLine("Enter the first addition value: ");
            string userInput = Console.ReadLine();
            num1 = int.Parse(userInput);
            Console.WriteLine("Enter the second addition value: ");
            string userInput2 = Console.ReadLine();
            num2 = int.Parse(userInput2); //Looks like this method means I have to make multiple userInput variables.

            int result = num1 + num2;
            Console.WriteLine("Your Sum is: ");
            Console.WriteLine(result);


            //Subtract, Multiply and Divide Numbers
            int num3; //blank input for other equations
            int num4; //blank input for other equations

            Console.WriteLine("Enter the first value: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            int result2 = num3 + num4;
            Console.WriteLine("Your Result is: ");
            Console.WriteLine(result2);

            result2 = num3 * num4;
            Console.WriteLine("Your Result is: ");
            Console.WriteLine(result2);

            double result3 = (double)num3 / (double)num4;
            Console.WriteLine("Your Result is: ");
            Console.WriteLine(result3);


            //2: Hello (Your Name)
            Console.WriteLine("What is your name?   ");
            string nameInput = Console.ReadLine();
            Console.WriteLine("Hello, " + nameInput);



            //3: Multiplication of 3 numbers
            int num5; //multiplication variable 1
            int num6; //multiplication variable 2
            int num7; //multiplication variable 3

            Console.WriteLine("Enter number 1 of 3 for multiplying: ");
            num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 of 3 for multiplying: ");
            num6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3 ofr 3 for multiplying: ");
            num7 = Convert.ToInt32(Console.ReadLine());

            int result4 = num5 * num6 * num7;
            Console.WriteLine("Your Product is: ");
            Console.WriteLine(result4);


            //4: Flattery.exe
            Console.WriteLine("How old are you, " + nameInput + "?");
            string ageInput = Console.ReadLine();
            Console.WriteLine("Wow, I would never have guessed " + ageInput + "! Do all " + ageInput + " year-olds look as good as you?");
        }


    }
}
