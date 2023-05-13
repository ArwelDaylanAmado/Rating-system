using System;

namespace RatingSystem
{
    class Program
    {
        static void Main()
        {
            string Hotel = "Laguna Hotel";
            
            Console.WriteLine("Rating system of Laguna Hotel");
            Console.Write("Enter Name of hotel:");

            string? userInput = Console.ReadLine();

            while(userInput != "0")
            {
                string result = userInput == Hotel ? "correct" : "error";

                if (result == "correct")
                {
                    Console.WriteLine("Rate the following from 1 as lowest and 5 as highest");
                    Console.WriteLine("1.Services");
                    Console.Write("Enter your Rate:");
                    Console.ReadLine();
                    
                    Console.WriteLine("2.Foods");
                    Console.Write("Enter your Rate:");
                    Console.ReadLine();
                    
                    Console.WriteLine("3.Cleanliness of the hotel");
                    Console.Write("Enter your Rate:");
                    Console.ReadLine();
                    
                    Console.WriteLine("4.Cleanliness of the room");
                    Console.Write("Enter your Rate:");
                    Console.ReadLine();
                    
                    Console.WriteLine("5.Entertainment");
                    Console.Write("Enter your Rate:");
                    Console.ReadLine();
                    Console.WriteLine("Thank u for rating us!!");
                    
                    break;
                }
                else
                {
                    Console.WriteLine("Name not found");
                    Console.WriteLine("Please try again");

                    Console.Write("Enter Name of hotel:");
                    userInput = Console.ReadLine();
                }
            }

        }
    }
}
