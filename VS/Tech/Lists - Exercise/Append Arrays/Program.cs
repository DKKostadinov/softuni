using System;
using System.Linq;
using System.Collections.Generic;

namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> listOfArrays = Console.ReadLine()
                .Split("|")
                .ToList();
            listOfArrays.Reverse();
            foreach (var item in listOfArrays)
            {
                int[] array = item
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                foreach (var num in array)
                {
                    Console.Write(num + " ");
                }
            }


        }
    }
}
