using System;
using System.Linq;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictOfResources = new Dictionary<string, int>();
            string resource = string.Empty;
            while ((resource = Console.ReadLine()) != "stop" )
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!dictOfResources.ContainsKey(resource))
                    dictOfResources.Add(resource, quantity);
                else
                    dictOfResources[resource] += quantity;
            }

            foreach (var kvp in dictOfResources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
