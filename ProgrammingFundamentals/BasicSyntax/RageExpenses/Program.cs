using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesLost = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());

            double price = gamesLost / 2 * headset + gamesLost / 3 * mouse + gamesLost / 6 * keyboard + gamesLost / 12 * display;
            Console.WriteLine($"Rage expenses: {price:0.00} lv.");
        }
    }
}
