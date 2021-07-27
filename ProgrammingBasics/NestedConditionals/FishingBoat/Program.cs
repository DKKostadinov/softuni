using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());
            double price = 0;
            if (season == "Spring") price = 3000;
            if (season == "Summer") price = 4200;
            if (season == "Autumn") price = 4200;
            if (season == "Winter") price = 2600;
            if (fisherman <= 6) price *= 0.9;
            else if (fisherman <= 11) price *= 0.85;
            else price *= 0.75;
            if (fisherman % 2 == 0 && season != "Autumn") price *= 0.95;

            if (budget >= price) Console.WriteLine($"Yes! You have {(budget-price):0.00} leva left.");
            else Console.WriteLine($"Not enough money! You need {price-budget:0.00} leva.");
        }
    }
}
