using System;
using System.Collections.Generic;
using System.Linq;

namespace Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> dict = new SortedDictionary<string, List<string>>();
            List<string> input = Console.ReadLine().Split(" | ").ToList();
            foreach (var item in input)
            {
                List<string> listOfDefs = new List<string>();
                string dictWord = item.Split(": ")[0];
                string dictDef = item.Split(": ")[1];
                if (dict.ContainsKey(dictWord))
                {
                    listOfDefs = dict[dictWord];
                    listOfDefs.Add(dictDef);
                    dict[dictWord] = listOfDefs;
                }
                else
                {
                    listOfDefs.Add(dictDef);
                    dict.Add(dictWord, listOfDefs);
                }
            }

            List<string> pulledWords = Console.ReadLine().Split(" | ").ToList();
            foreach (var item in pulledWords)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item] = SortByLength(dict[item]);
                    Console.WriteLine(item);
                    foreach (var def in dict[item])
                    {
                        Console.WriteLine(" -" + def);
                    }
                }
            }

            string lastInput = Console.ReadLine();
            if (lastInput == "End")
            {
                return;
            }
            else
            {
                foreach (var kvp in dict)
                {
                    Console.Write(kvp.Key + " ");
                }
            }
        }

        static List<string> SortByLength(List<string> e)
        {
            // Use LINQ to sort the array received and return a copy.
            var sorted = from s in e
                         orderby s.Length descending
                         select s;
            return sorted.ToList();
        }
    }
}
