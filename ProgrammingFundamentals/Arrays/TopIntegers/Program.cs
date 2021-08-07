using System;
using System.Linq;

namespace TopIntegers
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
                int element = arr[i];
                bool isTop = true;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] >= element) isTop = false;
                }
                if (isTop) Console.Write(element + " ");
            }
        }
    }
}
