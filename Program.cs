using System;
using System.Collections.Generic;

namespace RatingSystem
{
    internal class Program
    {
        static List<string> hotelnames = new List<string>();
        static void Main(string[] args)
        {
            hotelnames.Add("San Pedro Hotel");
            hotelnames.Add("Manila Hotel");
            hotelnames.Add("Santa Rosa Hotel");

            Console.WriteLine("Hotel names: ");
            DisplayListContents();

            Console.Write("\nEnter the hotel that you want to rate: ");
            var searchhotel = Console.ReadLine();
            var result = hotelnames.Find(x => x == searchhotel);

            if (result != null)
            {
                double num1, num2, num3, num4, num5, Total;

                    Console.WriteLine("Rate the following from 1 as lowest and 5 as highest");
                    Console.WriteLine("1.Services");
                    Console.Write("Enter your Rate:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("2.Foods");
                    Console.Write("Enter your Rate:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("3.Cleanliness of the hotel");
                    Console.Write("Enter your Rate:");
                    num3 = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("4.Cleanliness of the room");
                    Console.Write("Enter your Rate:");
                    num4 = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("5.Entertainment");
                    Console.Write("Enter your Rate:");
                    num5 = Convert.ToDouble(Console.ReadLine());

                    Total = (num1 + num2 + num3 + num4 + num5) / 5;
                    Console.WriteLine("rating total:" +Total );
                    
            }
            else
            {
                Console.WriteLine("Name not found");
                Console.WriteLine("Please try again");
            }
        }

        static void DisplayListContents()
        {
            foreach (var book in hotelnames)
            {
                Console.WriteLine(book);
            }
        }
    }
}
