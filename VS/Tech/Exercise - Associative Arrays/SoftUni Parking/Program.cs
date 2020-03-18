using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            var parkedCars = new Dictionary<string, string>();
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ");
                if (command[0] == "register")
                {
                    if (parkedCars.ContainsKey(command[1]))
                        Console.WriteLine($"ERROR: already registered with plate number {command[2]}");
                    else
                    {
                        parkedCars.Add(command[1], command[2]);
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                }
                if (command[0] == "unregister")
                {
                    if (!parkedCars.ContainsKey(command[1]))
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    else
                    {
                        parkedCars.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                }
            }
            foreach (var kvp in parkedCars)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
