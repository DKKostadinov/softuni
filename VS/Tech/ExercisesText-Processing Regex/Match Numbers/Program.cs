using System;
using System.Text.RegularExpressions;

namespace Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            string[] input = Console.ReadLine().Split(" ");
            Regex order = new Regex(pattern);
            foreach (var item in input)
            {
                if (order.IsMatch(item))
                    Console.Write(item + " ");
            }


        }
    }
}
