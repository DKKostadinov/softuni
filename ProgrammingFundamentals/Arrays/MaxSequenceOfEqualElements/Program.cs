using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int bestSequence = -1;
            int currentSequence = 1;
            int bestNum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i] == arr[i - 1])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                }
                if (currentSequence > bestSequence)
                {
                    bestSequence = currentSequence;
                    bestNum = arr[i];
                }
            }
            for (int i = 0; i < bestSequence; i++)
            {
                Console.Write(bestNum + " ");
            }
        }
    }
}
