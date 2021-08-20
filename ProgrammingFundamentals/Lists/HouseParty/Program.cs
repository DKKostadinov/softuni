using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine()
                    .Split(" ")
                    .ToList();
                string person = input[0];
                if (input.Contains("not"))
                {
                    if (guests.Contains(person))
                    {
                        guests.Remove(person);
                    }
                    else
                    {
                        Console.WriteLine($"{person} is not in the list!");
                    }
                }
                else
                {
                    if (guests.Contains(person))
                    {
                        Console.WriteLine($"{person} is already in the list!");
                    }
                    else
                    {
                        guests.Add(person);
                    }
                }
            }
            foreach (var item in guests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
