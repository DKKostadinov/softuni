using System;
using System.Linq;
using System.Collections.Generic;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collectionOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            while (true)
            {
                List<string> commands = Console.ReadLine()
                    .Split()
                    .ToList();
                switch (commands[0])
                {
                    case "end":
                        foreach (var item in collectionOfNumbers)
                        {
                            Console.Write(item + " ");
                        }
                        return;
                    case "Delete":
                        while (collectionOfNumbers.Contains(int.Parse(commands[1])))
                        {
                            collectionOfNumbers.Remove(int.Parse(commands[1]));
                        }
                        break;
                    case "Insert":
                        collectionOfNumbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
