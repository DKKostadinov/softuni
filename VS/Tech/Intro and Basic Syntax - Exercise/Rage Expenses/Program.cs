using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double rageCost = headsetPrice * (numberOfGames / 2) + mousePrice * (numberOfGames / 3) +
                keyboardPrice * (numberOfGames / 6) + displayPrice * (numberOfGames / 12);
            Console.WriteLine($"Rage expenses: {rageCost:f2} lv.");

        }
    }
}
