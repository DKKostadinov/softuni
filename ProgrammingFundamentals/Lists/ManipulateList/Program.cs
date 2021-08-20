using System;
using System.Collections.Generic;
using System.Linq;

namespace ManipulateList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            while (true)
            {
                List<string> input = Console.ReadLine()
                    .Split(" ")
                    .ToList();
                if (input[0] == "end") break;
                if (input[0] == "Delete")
                {
                    numbers.RemoveAll(x=>x==int.Parse(input[1]));
                }
                if (input[0] == "Insert")
                {
                    int num = int.Parse(input[1]);
                    int index = int.Parse(input[2]);
                    numbers.Insert(index, num);
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
