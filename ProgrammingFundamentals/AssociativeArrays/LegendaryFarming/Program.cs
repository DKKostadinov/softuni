using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>()
            {
                {"fragments", 0 },
                {"motes", 0 },
                {"shards", 0 }
            };
            Dictionary<string, int> junk = new Dictionary<string, int>();
            while (true)
            {
                string[] input = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 1; i <= input.Length; i+=2)
                {
                    if (input[i] == "motes" || input[i] == "fragments" || input[i] == "shards")
                    {
                        inventory[input[i]] += int.Parse(input[i - 1]);
                    }
                    else
                    {
                        if (junk.ContainsKey(input[i])) junk[input[i]] += int.Parse(input[i - 1]);
                        else junk.Add(input[i], int.Parse(input[i - 1]));
                    }
                }
                if(inventory["motes"] >= 250)
                {
                    inventory["motes"] -= 250;
                    Console.Write("Dragonwrath");
                    break;
                }
                if (inventory["fragments"] >= 250)
                {
                    inventory["fragments"] -= 250;
                    Console.Write("Valanyr");
                    break;
                }
                if (inventory["shards"] >= 250)
                {
                    inventory["shards"] -= 250;
                    Console.Write("Shadowmourne");
                    break;
                }
            }
            Console.WriteLine(" obtained!");
            inventory = inventory.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x=>x.Key, x=>x.Value);
            junk = junk.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var kvp in inventory)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }
    }
}
