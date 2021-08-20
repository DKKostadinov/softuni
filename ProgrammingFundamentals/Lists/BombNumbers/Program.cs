using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> bombInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int bombNum = bombInfo[0];
            int bombStr = bombInfo[1];
            while (numbers.Contains(bombNum))
            {
                int index = (numbers.IndexOf(bombNum) - bombStr < 0)? 0: numbers.IndexOf(bombNum) - bombStr;
                for (int i = 0; i < 2 * bombStr + 1; i++)
                {
                    if (numbers.Count <= index) break;
                    else numbers.RemoveAt(index);
                }

            }
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
