using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishermen = int.Parse(Console.ReadLine());
            double price = 0;

            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
                default:
                    break;
            }

            if (numberOfFishermen <= 6 && numberOfFishermen > 0) price *= 0.9;
            else if (numberOfFishermen <= 11 && numberOfFishermen >= 7) price *= 0.85;
            else if(numberOfFishermen >= 12) price *= 0.75;

            if (numberOfFishermen % 2 == 0 && season != "Autumn") price *= 0.95;

            if (budget - price >= 0) Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            else Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
        }
    }
}
