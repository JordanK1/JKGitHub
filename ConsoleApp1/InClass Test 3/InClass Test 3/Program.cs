using System;

namespace InClass_Test_3
{
    class Program
    {

        struct Books
        {
            public string title;
            public string author;
            public string subject;
            public int book_id;
        }

        struct coordinate
        {
            public int x;
            public int y;

            //create the parameterized coordinate structure
          /*  public coordinate(int x, int y)
            {
                this.x = x;
                this.y = y;
            }*/
            public int X { get; set; }
            public int Y { get; set; }

            public void SetOrigin()
            {
                this.X = 0;
                this.Y = 0;
            }
            
            public static coordinate GetOrigin()
            {
                return new coordinate();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Books book1; //  declare book1 of type book.
            Books book2; //  declare book2 of type book.

            book1.title = "C Programming";
            book1.author = "Nuha Ali";
            book1.subject = "C Programming Tutorial";
            book1.book_id = 12345;

            book2.title = "Telecom Billing";
            book2.author = "Zara Ali";
            book2.subject = "Telecom Billing Tutorial";
            book2.book_id = 67890;


            Console.WriteLine("Book 1 title: {0}", book1.title);
            Console.WriteLine("Book 2 title: {0}", book2.title);

            coordinate point = new coordinate();
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);

           /* coordinate point1;
            // Console.WriteLine(point1.x); This line will give a compiling error.

            point1.x = 10;
            point1.y = 20;
            Console.WriteLine(point1.x); // output: 10
            Console.WriteLine(point1.y); // output: 20

            coordinate point2 = new coordinate(30, 40);
            Console.WriteLine(point2.x);
            Console.WriteLine(point2.y);*/

            //methods and properties in structure
            coordinate point3 = new coordinate();
            point3.SetOrigin();
            Console.WriteLine(point3.X);
            Console.WriteLine(point3.Y);

            coordinate point4 = coordinate.GetOrigin();
            Console.WriteLine(point4.X);
            Console.WriteLine(point4.Y);
        }
    }
}
