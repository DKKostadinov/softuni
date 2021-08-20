using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<int> numbers = new List<int>();
            for (int i = input.Count-1; i >= 0; i--)
            {
                string subarray = input[i];
                numbers.AddRange(subarray.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
