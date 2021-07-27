using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int travel = int.Parse(Console.ReadLine());

            double games = 0;

            games += (double)(48 - travel) * 3 / 4 + travel + (double)holidays * 2 / 3;
            games = (year == "leap") ? games * 1.15 : games;

            Console.WriteLine(Math.Floor(games));
        }
    }
}
