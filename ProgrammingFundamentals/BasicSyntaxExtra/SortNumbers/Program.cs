using System;
using System.Collections.Generic;
using System.Linq;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            numbers.Sort();
            numbers.Reverse();
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
