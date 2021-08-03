using System;
using System.Collections.Generic;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = 0;
            List<double> validCoins = new List<double> { 2.0, 1.0, 0.5, 0.2, 0.1 };
            Dictionary<String, double> prices = new Dictionary<string, double>
            {
                {"Nuts", 2.0 },
                {"Water", 0.7 },
                {"Crisps", 1.5 },
                {"Soda", 0.8 },
                {"Coke", 1.0 }
            };
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Start") break;
                if(validCoins.Contains(double.Parse(input)) == false)
                {
                    Console.WriteLine($"Cannot accept {input}");
                    continue;
                }
                cash += double.Parse(input);
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") break;
                if (prices.ContainsKey(input) == false)
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }
                double price = prices[input];
                if(cash < price)
                {
                    Console.WriteLine("Sorry, not enough money");
                    continue;
                }
                cash -= price;
                Console.WriteLine($"Purchased {input.ToLower()}");
            }
            Console.WriteLine($"Change: {cash:0.00}");
        }
    }
}
