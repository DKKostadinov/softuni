using System;
using System.Collections.Generic;
using System.Linq;

namespace NewSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new SortedDictionary<string, List<string>>();

            var input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                var line = input.Split(" -> ").ToArray();

                var companyName = line[0];
                var employer = line[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                    companies[companyName].Add(employer);
                }
                else if (!companies[companyName].Contains(employer))
                {
                    companies[companyName].Add(employer);
                }
            }
            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");

                foreach (var item in company.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}