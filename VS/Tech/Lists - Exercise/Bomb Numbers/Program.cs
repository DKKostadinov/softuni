using System;
using System.Linq;
using System.Collections.Generic;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collectionOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> bombValueAndPower = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int bombValue = bombValueAndPower[0];
            int powerOfBomb = bombValueAndPower[1];
            int sumOfRemainingItems = 0;
            for (int i = 0; i < collectionOfNumbers.Count; i++)
            {
                if (collectionOfNumbers[i] == bombValue)
                {
                    int detonationStart = (i - powerOfBomb >= 0) ? (i - powerOfBomb) : 0;
                    int detonationEnd = (i + powerOfBomb < collectionOfNumbers.Count) ? (i + powerOfBomb) : collectionOfNumbers.Count - 1;
                    for (int j = 0; j <= detonationEnd - detonationStart; j++)
                    {
                        collectionOfNumbers.RemoveAt(detonationStart);
                    }
                }
            }
            foreach (var item in collectionOfNumbers)
            {
                sumOfRemainingItems += item;
            }

            Console.WriteLine(sumOfRemainingItems);
        }
    }
}
