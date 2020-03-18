using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfStrings = int.Parse(Console.ReadLine());
            int[] Array1 = new int[lengthOfStrings];
            int[] Array2 = new int[lengthOfStrings];

            for (int i = 0; i < lengthOfStrings; i++)
            {
                int[] inputNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                if (i % 2 == 1)
                {
                    Array2[i] = inputNumbers[0];
                    Array1[i] = inputNumbers[1];
                }
                else
                {
                    Array2[i] = inputNumbers[1];
                    Array1[i] = inputNumbers[0];
                }
            }

            foreach (var item in Array1)
            {
                Console.Write(item + " " );
            }
            Console.WriteLine();
            foreach (var item in Array2)
            {
                Console.Write(item + " ");
            }
        }
    }
}
