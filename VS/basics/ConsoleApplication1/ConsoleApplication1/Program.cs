using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double totalsum = ((puzzle * 2.6) + (dolls * 3.00) + (bears * 4.10) + (minions * 8.20) + (trucks * 2.00));

            if (puzzle + dolls + bears + minions + trucks > 50)
            {
                double promo = totalsum - (0.25 * totalsum);
                double rent = promo * 0.1;
                double win = (promo - rent);
                if (win > trip)
                {
                    double MoneyLeft = win - trip;
                    Console.WriteLine($"Yes! {MoneyLeft:f2} lv left.");
                }
                else if (win < trip)
                {
                    double MoneyNeeded = trip - win;
                    Console.WriteLine($"Not enough money! {MoneyNeeded:f2} lv needed.");
                }
            }
            else if (puzzle + dolls + bears + minions + trucks < 50)
            {
                double rent = 0.1 * totalsum;
                double win = totalsum - rent;
                if (win > trip)
                {
                    double MoneyLeft = win - trip;
                    Console.WriteLine($"Yes! {MoneyLeft:f2} lv left.");
                }
                else if (win < trip)
                {
                    double MoneyNeeded = trip - win;
                    Console.WriteLine($"Not enough money! {MoneyNeeded:f2} lv needed.");
                }
            }



        }
    }
}