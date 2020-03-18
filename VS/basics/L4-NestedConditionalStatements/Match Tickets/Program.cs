using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            if (people >= 1 && people < 5)
                budget *= 0.25;
            else if (people >= 5 && people < 10)
                budget *= 0.4;
            else if (people >= 10 && people < 25)
                budget *= 0.5;
            else if (people >= 25 && people < 50)
                budget *= 0.6;
            else if (people >= 50)
                budget *= 0.75;

            switch (category)
            {
                case "VIP":
                    if (budget - people * 499.99 >= 0)
                        Console.WriteLine($"Yes! You have {(budget - people * 499.99):f2} leva left.");
                    else Console.WriteLine($"Not enough money! You need {(Math.Abs(budget - people * 499.99)):f2} leva.");
                    break;
                case "Normal":
                    if (budget - people * 249.99 >= 0)
                        Console.WriteLine($"Yes! You have {(budget - people * 249.99):f2} leva left.");
                    else Console.WriteLine($"Not enough money! You need {(Math.Abs(budget - people * 249.99)):f2} leva.");
                    break;
                default:
                    break;
            }
        }
    }
}
