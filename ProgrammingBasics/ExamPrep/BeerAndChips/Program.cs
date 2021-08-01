using System;

namespace BeerAndChips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beers = int.Parse(Console.ReadLine());
            int chips = int.Parse(Console.ReadLine());
            double beerPrice = 1.2;
            double chipsPrice = 0.45 * beerPrice * beers;
            double totalCost = beers * beerPrice + Math.Ceiling(chips * chipsPrice);
            if (budget >= totalCost) Console.WriteLine($"{name} bought a snack and has {budget - totalCost:0.00} leva left.");
            else Console.WriteLine($"{name} needs {totalCost-budget:0.00} more leva!");
        }
    }
}
