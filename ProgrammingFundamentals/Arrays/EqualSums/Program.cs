using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                int sum1 = 0;
                int sum2 = 0;
                for (int j = 0; j < i; j++)
                {
                    sum1 += arr[j];
                }
                for (int j = i+1; j < arr.Length; j++)
                {
                    sum2 += arr[j];
                }
                if(sum1 == sum2)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
