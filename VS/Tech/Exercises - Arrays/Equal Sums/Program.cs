using System;
using System.Linq;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int index = -1;
            int totalSum = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                totalSum += inputArray[i];
            }

            for (int i = 0; i < inputArray.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < i; j++)
                {
                    sum += inputArray[j];
                }

                if (sum * 2 == totalSum - inputArray[i])
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
