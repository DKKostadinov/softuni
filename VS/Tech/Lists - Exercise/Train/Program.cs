using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int capacityOfWagons = int.Parse(Console.ReadLine());

            while (true)
            {
                List<string> commands = Console.ReadLine()
                    .Split()
                    .ToList();
                if (commands[0] == "end")
                    break;
                if (commands[0] == "Add")
                    wagons.Add(int.Parse(commands[1]));
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + int.Parse(commands[0]) <= capacityOfWagons)
                        {
                            wagons[i] += int.Parse(commands[0]);
                            break;
                        }
                    }
                }
            }

            foreach (var item in wagons)
            {
                Console.Write(item + " ");
            }
        }
    }
}
