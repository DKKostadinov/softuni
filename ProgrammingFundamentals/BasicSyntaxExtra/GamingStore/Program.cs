using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double currentBalance = balance;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Game Time") break;
                double price = 0;
                switch (input)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (currentBalance >= price) 
                {
                    currentBalance -= price;
                    Console.WriteLine($"Bought {input}");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            Console.WriteLine($"Total spent: ${balance-currentBalance:0.00}. Remaining: ${currentBalance:0.00}");
        }
    }
}
