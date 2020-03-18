namespace Socks
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> leftSocks = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> rightSocks = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> pairedSocks = new List<int>();
            int biggestPair = 0;
            while (leftSocks.Count > 0 && rightSocks.Count > 0)
            {
                int currentLeft = leftSocks[leftSocks.Count - 1];
                int currentRight = rightSocks[0];

                if (currentLeft > currentRight)
                {
                    pairedSocks.Add(currentRight + currentLeft);
                    leftSocks.RemoveAt(leftSocks.Count - 1);
                    rightSocks.RemoveAt(0);
                    if (currentRight + currentLeft > biggestPair)
                        biggestPair = currentLeft + currentRight;
                }
                else if (currentRight > currentLeft)
                {
                    leftSocks.RemoveAt(leftSocks.Count - 1);
                }
                else if (currentLeft == currentRight)
                {
                    rightSocks.RemoveAt(0);
                    leftSocks[leftSocks.Count - 1]++;
                }
            }
            Console.WriteLine(biggestPair);
            foreach (var item in pairedSocks)
            {
                Console.Write(item + " ");
            }

        }
    }
}
