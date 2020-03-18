using System;
using System.Linq;

namespace GeneratingCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] set = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] vector = new int[int.Parse(Console.ReadLine())];
            GenCombos(set, vector, 0, -1);
        }

        private static void GenCombos(int[] set, int[] vector, int indexOfPositionInVector, int indexOfAlreadyUsedNumbersInArray)
        {
            if (indexOfPositionInVector >= vector.Length)
            {
                foreach (var charFromVector in vector)
                {
                    Console.Write(charFromVector + " ");
                }
                Console.WriteLine();
                return;
            }

            for (int i = indexOfAlreadyUsedNumbersInArray + 1; i < set.Length; i++)
            {
                vector[indexOfPositionInVector] = set[i];
                GenCombos(set, vector, indexOfPositionInVector + 1, i);
            }
        }
    }
}
