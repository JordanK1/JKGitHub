using System;

namespace Lab5_6JordanK
{
    class Program
    {
        struct Customer
        {
            public int customer_id;
            public string first_name;
            public string last_name;
            public int age;
            public bool hasMembership;
        }
        static void Main(string[] args)
        {
            Customer num1 = new Customer
            {
                customer_id = 1,
                first_name = "Richard",
                last_name = "Freeman",
                age = 19,
                hasMembership = false
            };

            Customer num2 = new Customer
            {
                customer_id = 2,
                first_name = "Ezekiel",
                last_name = "Rye",
                age = 35,
                hasMembership = false
            };

            Customer num3 = new Customer
            {
                customer_id = 3,
                first_name = "Julie",
                last_name = "Yoon",
                age = 24,
                hasMembership = true
            };

            Customer[] currentList = { num1, num2, num3 };

            for (int i = 0; i < currentList.Length; i++)
            {
                if (currentList[i].age < 21)
                {
                    Console.WriteLine(currentList[i].first_name + " is underage. The order has been cancelled.");
                    continue;
                }
                else
                {
                    Console.WriteLine("The order can be fulfilled.");
                }

                if (currentList[i].hasMembership == false)
                {
                    Console.WriteLine("Your order has been placed, " + currentList[i].first_name + ". If you are interested in future discounts, " +
                        "please consider signing up for our Premium Membership.");
                }
                else
                {
                    Console.WriteLine("Thank you for support " + currentList[i].first_name + ". Your order has been placed. Thank you " +
                        "for shopping with World of Beers!");
                }
            }


        }
    }
}
