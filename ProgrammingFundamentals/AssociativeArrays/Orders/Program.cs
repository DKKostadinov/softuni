using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> prices = new Dictionary<string, double>();
            Dictionary<string, int> quantities = new Dictionary<string, int>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "buy") break;
                string item = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);
                if(prices.ContainsKey(item) && quantities.ContainsKey(item))
                {
                    quantities[item] += quantity;
                    prices[item] = price;
                }
                else
                {
                    prices.Add(item, price);
                    quantities.Add(item, quantity);
                }
            }
            foreach (var kvp in quantities)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value*prices[kvp.Key]:0.00}");
            }
        }
    }
}
