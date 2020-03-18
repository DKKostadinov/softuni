using System;
using System.Linq;
using System.Collections.Generic;

namespace Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOne = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> playerTwo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sumOfWinningHand = 0;
            int indexOfHandOne = 0;
            int indexOfHandTwo = 0;

            while (playerOne.Count > 0 && playerTwo.Count > 0)
            {
                indexOfHandOne = (indexOfHandOne < playerOne.Count) ? indexOfHandOne : 0;
                indexOfHandTwo = (indexOfHandTwo < playerTwo.Count) ? indexOfHandTwo : 0;

                if (playerOne[indexOfHandOne] > playerTwo[indexOfHandTwo])
                {
                    playerOne.Add(playerOne[indexOfHandOne]);
                    playerOne.Add(playerTwo[indexOfHandTwo]);
                }
                else if (playerOne[indexOfHandOne] < playerTwo[indexOfHandTwo])
                {
                    playerTwo.Add(playerTwo[indexOfHandTwo]);
                    playerTwo.Add(playerOne[indexOfHandOne]);
                }
                playerTwo.RemoveAt(indexOfHandOne);
                playerOne.RemoveAt(indexOfHandTwo);
            }

            if (playerOne.Count > 0)
            {
                foreach (var item in playerOne)
                {
                    sumOfWinningHand += item;
                }
                Console.WriteLine($"First player wins! Sum: {sumOfWinningHand}");
            }
            else
            {
                foreach (var item in playerTwo)
                {
                    sumOfWinningHand += item;
                }
                Console.WriteLine($"Second player wins! Sum: {sumOfWinningHand}");
            }

        }
    }
}
