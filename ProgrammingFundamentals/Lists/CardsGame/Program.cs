using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> player2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            while (player1.Count > 0 && player2.Count > 0)
            {
                if (player1[0] > player2[0])
                {
                    player1.Add(player1[0]);
                    player1.Add(player2[0]);
                }
                else if (player2[0] > player1[0])
                {
                    player2.Add(player2[0]);
                    player2.Add(player1[0]);
                }
                player2.RemoveAt(0);
                player1.RemoveAt(0);
                player1.TrimExcess();
                player2.TrimExcess();
            }
            if (player1.Count > 0)
            {
                int sum = 0;
                foreach (var item in player1)
                {
                    sum += item;
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                int sum = 0;
                foreach (var item in player2)
                {
                    sum += item;
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
