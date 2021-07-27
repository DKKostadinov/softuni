using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = "";
            string type = "";
            double price = 0;
            if (budget <= 100)
            {
                location = "Bulgaria";
                if (season == "summer")
                {
                    price = 0.3 * budget;
                    type = "Camp";
                }
                else
                {
                    price = 0.7 * budget;
                    type = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                location = "Balkans";
                if (season == "summer")
                {
                    price = 0.4 * budget;
                    type = "Camp";
                }
                else
                {
                    price = 0.8 * budget;
                    type = "Hotel";
                }
            }
            else
            {
                location = "Europe";
                price = 0.9 * budget;
                type = "Hotel";
            }

            Console.WriteLine($"Somewhere in {location}");
            Console.WriteLine($"{type} - {price:0.00}");
        }
    }
}
