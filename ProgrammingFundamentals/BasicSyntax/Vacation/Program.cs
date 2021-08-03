using System;
using System.Collections.Generic;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            Dictionary<String, int> types = new Dictionary<string, int>
            {
                { "Students", 0},
                { "Business", 1},
                { "Regular" , 2}
            };
            Dictionary<String, int> days = new Dictionary<string, int>
            {
                { "Friday", 0},
                { "Saturday", 1},
                { "Sunday" , 2}
            };
            double[,] prices = new double[3, 3]
            {
                { 8.45, 9.80, 10.46},
                {10.90, 15.60, 16 },
                {15, 20, 22.50 }
            };
            double price = prices[types[groupType], days[day]];
            price *= groupSize;
            if (groupType == "Students" && groupSize >= 30) price *= 0.85;
            if (groupType == "Business" && groupSize >= 10) price -= 10 * prices[days[day], types["Business"]];
            if (groupType == "Regular" && groupSize >= 10 && groupSize <= 20) price *= 0.95;
            Console.WriteLine($"Total price: {price:0.00}");
        }
    }
}
