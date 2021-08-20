using System;
using System.Collections.Generic;

namespace SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingLot = new Dictionary<string, string>();
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string command = input[0];
                string user = input[1];
                if (command == "register")
                {
                    string plate = input[2];
                    if (parkingLot.ContainsKey(user)) Console.WriteLine($"ERROR: already registered with plate number {parkingLot[user]}");
                    else
                    {
                        parkingLot.Add(user, plate);
                        Console.WriteLine($"{user} registered {plate} successfully");
                    }
                }
                else
                {
                    if (!parkingLot.ContainsKey(user)) Console.WriteLine($"ERROR: user {user} not found");
                    else
                    {
                        parkingLot.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                }
            }
            foreach (var kvp in parkingLot)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
