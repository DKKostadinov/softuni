using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int capacity = int.Parse(Console.ReadLine());
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") break;
                List<string> inputList = input.Split(" ").ToList();
                if(inputList[0] == "Add")
                {
                    wagons.Add(int.Parse(inputList[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count(); i++) 
                    {
                        if (wagons[i] + int.Parse(inputList[0]) <= capacity)
                        {
                            wagons[i] += int.Parse(inputList[0]);
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
