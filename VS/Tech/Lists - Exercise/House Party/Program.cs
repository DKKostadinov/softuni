using System;
using System.Linq;
using System.Collections.Generic;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string>();
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> command = Console.ReadLine()
                    .Split()
                    .ToList();
                switch (command[2])
                {
                    case "going!":
                        if (guestList.Contains(command[0]))
                            Console.WriteLine($"{command[0]} is already in the list!");
                        else guestList.Add(command[0]);
                        break;
                    case "not":
                        if (guestList.Contains(command[0]))
                            guestList.Remove(command[0]);
                        else
                            Console.WriteLine($"{command[0]} is not in the list!");
                        break;
                    default:
                        break;
                }
            }

            foreach (var item in guestList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
