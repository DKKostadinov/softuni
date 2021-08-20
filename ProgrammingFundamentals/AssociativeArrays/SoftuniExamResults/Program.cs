using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftuniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> languageCount = new Dictionary<string, int>();
            Dictionary<string, int> userPoints = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exam finished") break;
                if(input.Contains("banned"))
                {
                    string user = input.Split("-")[0];
                    userPoints.Remove(user);
                }
                else
                {
                    string user = input.Split("-")[0];
                    string lang = input.Split("-")[1];
                    int pts = int.Parse(input.Split("-")[2]);
                    if (languageCount.ContainsKey(lang)) languageCount[lang]++;
                    else languageCount.Add(lang, 1);
                    if (userPoints.ContainsKey(user)) userPoints[user] = (pts > userPoints[user]) ? pts : userPoints[user];
                    else userPoints.Add(user, pts);
                }
            }
            userPoints = userPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            languageCount = languageCount.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("Results:");
            foreach (var kvp in userPoints)
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var kvp in languageCount)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }

        }
    }
}
