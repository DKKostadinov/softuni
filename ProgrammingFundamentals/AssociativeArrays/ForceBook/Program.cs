using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo") break;
                if (input.Contains("|"))
                {
                    string[] inputArr = input.Split(" | ");
                    string side = inputArr[0];
                    string user = inputArr[1];
                    if (sides.ContainsKey(side))
                    {
                        if (sides[side].Contains(user)) continue;
                        else sides[side].Add(user);
                    }
                    else
                    {
                        sides.Add(side, new List<string>() { user });
                    }
                }
                else
                {

                    string[] inputArr = input.Split(" -> ");
                    string user = inputArr[0];
                    string side = inputArr[1];
                    foreach (var kvp in sides)
                    {
                        if (kvp.Value.Contains(user)) sides[kvp.Key].Remove(user);
                    }
                    sides[side].Add(user);
                    Console.WriteLine($"{user} joins the {side} side!");
                }
            }
            sides = sides.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var side in sides)
            {
                sides[side.Key].Sort();
                if(side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    foreach (var user in side.Value)
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}
