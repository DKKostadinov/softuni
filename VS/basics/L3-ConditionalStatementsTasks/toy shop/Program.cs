using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toy_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfHoliday = double.Parse(Console.ReadLine());
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfDolls = int.Parse(Console.ReadLine());
            int numberOfBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            double moneyEarned = numberOfBears * 4.10 + numberOfDolls * 3 + numberOfMinions * 8.20 + numberOfPuzzles * 2.60 
                                + numberOfTrucks * 2;

            if (numberOfBears + numberOfDolls + numberOfMinions + numberOfPuzzles + numberOfTrucks >= 50)
            {
                moneyEarned = moneyEarned - moneyEarned * 0.25;
            }
            moneyEarned = moneyEarned - moneyEarned * 0.10;
            
            if (moneyEarned >= priceOfHoliday) Console.WriteLine($"Yes! {(moneyEarned - priceOfHoliday):F2} lv left.");
            else Console.WriteLine($"Not enough money! {(priceOfHoliday - moneyEarned):F2} lv needed.");
        }
    }
}
