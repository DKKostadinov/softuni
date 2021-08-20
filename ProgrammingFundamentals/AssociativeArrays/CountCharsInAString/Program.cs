using System;
using System.Collections.Generic;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Replace(" ", string.Empty);
            Dictionary<char, int> charCounter = new Dictionary<char, int>();
            foreach (var c in input)
            {
                if (charCounter.ContainsKey(c)) charCounter[c]++;
                else charCounter.Add(c, 1);
            }
            foreach (var kvp in charCounter)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
