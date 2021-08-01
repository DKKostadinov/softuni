using System;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string bestPlayer = "";
            int bestGoals = 0;
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "END") break;
                int goals = int.Parse(Console.ReadLine());
                if (goals > bestGoals)
                {
                    bestPlayer = name;
                    bestGoals = goals;
                }
                if (goals >= 3) break;
            }
            Console.Write($"{bestPlayer} is the best player!\nHe has scored {bestGoals}");
            if (bestGoals >= 3) Console.Write(" and made a hat-trick !!!");
            else Console.Write(".");
        }
    }
}
