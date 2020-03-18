using System;
using System.Linq;

namespace RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int result = Sum(input, 0);
            Console.WriteLine(result);
        }

        static int Sum(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                return 0;
            }
            else
            {
                return arr[index] + Sum(arr, index + 1);
            }
        }

    }
}
