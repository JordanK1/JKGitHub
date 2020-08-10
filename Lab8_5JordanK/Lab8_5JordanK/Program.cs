using System;

namespace Lab8_5JordanK
{
    class Program
    {
          
            static void Main(string[] args)
            {
            HouseHunters HHapp1 = new HouseHunters("Full Stack Web Developer", 100000, "In about 6 months", 3, 2, 
                "Omar", "Smith", "2/4/1975", "111 Bravo Way", "Los Angeles", "California", 90001, "888-233-1234","omar.smith@hotmail.com");

            ParadiseIsland PIapp2 = new ParadiseIsland("female", "Carl", 2, "Patti", "Johnson", "5/4/1994", "211 Love Rd.", "Los Angeles", "California", 90001, "988-444-1234",
                "patti.johnson@gmail.com");

            AboveDeckjk ADapp3 = new AboveDeckjk(20, "American", "Captian", "Lee", "7/12/1964", "311 Bravo Way", "Los Angeles", "California", 90001, "711-333-1234",
                "captian@gmail.com");

            HHapp1.Submit();
            HHapp1.Accept();

            PIapp2.Submit();
            PIapp2.Accept();

            ADapp3.Submit();
            ADapp3.Accept();
            }
        
    }
}
