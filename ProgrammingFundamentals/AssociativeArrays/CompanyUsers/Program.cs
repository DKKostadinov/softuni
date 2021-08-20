using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyIDs = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                if (input[0] == "End") break;
                string companyName = input[0];
                string id = input[1];
                if (companyIDs.ContainsKey(companyName))
                {
                    if (companyIDs[companyName].Contains(id)) continue;
                    companyIDs[companyName].Add(id);
                }
                else
                {
                    companyIDs.Add(companyName, new List<string>() { id });
                }
            }
            companyIDs = companyIDs.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var kvp in companyIDs)
            {
                Console.WriteLine(kvp.Key);
                foreach (var id in kvp.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
