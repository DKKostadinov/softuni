using System;
using System.Collections.Generic;

namespace FanShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> prices = new Dictionary<string, int>();
            prices.Add("hoodie", 30);
            prices.Add("keychain", 4);
            prices.Add("T-shirt", 20);
            prices.Add("flag", 15);
            prices.Add("sticker", 1);

            int budget = int.Parse(Console.ReadLine());
            int items = int.Parse(Console.ReadLine());
            for (int i = 0; i < items; i++)
            {
                string currentItem = Console.ReadLine();
                budget -= prices[currentItem];
            }
            if (budget < 0) Console.WriteLine($"Not enough money, you need {Math.Abs(budget)} more lv.");
            else Console.WriteLine($"You bought {items} items and left with {budget} lv.");
        }
    }
}
