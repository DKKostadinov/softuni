using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> test = new Dictionary<string, int>
            {
                {"B", 4},
                {"D", 2},
                {"C", 2},
                {"A", 3},
                {"F", 1},
            };
            IOrderedEnumerable<KeyValuePair<string, int>> sortedCollection = test
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key);
            foreach (var kvp in sortedCollection)
            {
                Console.WriteLine(kvp.Key + "   " + kvp.Value);
            }
        }
    }
}

/*Dictionary<string, string> d = new Dictionary<string, string>
{
  {"A","Z"},
  {"B","Y"},
  {"C","X"}
};

d.OrderBy(x=>x.Value).Select(x=>x.Key);
*/