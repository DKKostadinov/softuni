using System;
using System.Linq;
using System.Collections.Generic;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyInventory = new Dictionary<string, int>();
            keyInventory.Add("shards", 0);
            keyInventory.Add("fragments", 0);
            keyInventory.Add("motes", 0);
            var inventory = new Dictionary<string, int>();
            while (true)
            {
                if (keyInventory["shards"] >= 250 || keyInventory["fragments"] >= 250 || keyInventory["motes"] >= 250)
                    break;
                List<string> input = Console.ReadLine()
                    .ToLower()
                    .Split(" ")
                    .ToList();
                for (int i = 0; i < input.Count; i += 2)
                {
                    if (!(input[i + 1] == "shards" || input[i + 1] == "motes" || input[i + 1] == "fragments"))
                    {
                        if (!inventory.ContainsKey(input[i + 1]))
                        {
                            inventory.Add(input[i + 1], 0);
                        }
                        inventory[input[i + 1]] += int.Parse(input[i]);
                    }
                    else
                    {
                        keyInventory[input[i + 1]] += int.Parse(input[i]);
                        if (keyInventory["shards"] >= 250 || keyInventory["fragments"] >= 250 || keyInventory["motes"] >= 250)
                            break;
                    }

                }
            }

            if (keyInventory["shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                keyInventory["shards"] -= 250;
            }
            if (keyInventory["fragments"] >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                keyInventory["fragments"] -= 250;
            }
            if (keyInventory["motes"] >= 250)
            {
                keyInventory["motes"] -= 250;
                Console.WriteLine("Dragonwrath obtained!");
            }

            foreach (var kvp in keyInventory.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in inventory.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}