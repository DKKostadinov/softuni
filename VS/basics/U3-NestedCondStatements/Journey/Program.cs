using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                if (season == "summer") Console.WriteLine($"Somewhere in Bulgaria\nCamp - {(budget * 0.30):f2}");
                else Console.WriteLine($"Somewhere in Bulgaria\nHotel - {(budget * 0.70):f2}");
            }
            else if (budget <= 1000)
            {
                if (season == "summer") Console.WriteLine($"Somewhere in Balkans\nCamp - {(budget * 0.40):f2}");
                else Console.WriteLine($"Somewhere in Balkans\nHotel - {(budget * 0.80):f2}");
            }
            else
            {
                Console.WriteLine($"Somewhere in Europe\nHotel - {(budget * 0.90):f2}");
            }
        }
    }
}
