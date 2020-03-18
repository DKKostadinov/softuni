
using System;
using System.Linq;
using System.Collections.Generic;

namespace List_Operations
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
                List<string> command = Console.ReadLine()
                    .Split()
                    .ToList();
                switch (command[0])
                {
                    case "End":
                        foreach (var item in collectionOfNumbers)
                        {
                            Console.Write(item + " ");
                        }
                        return;
                    case "Add":
                        collectionOfNumbers.Add(int.Parse(command[1]));
                        break;
                    case "Insert":
                        if (int.Parse(command[2]) >= collectionOfNumbers.Count() || int.Parse(command[2]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        collectionOfNumbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    case "Remove":
                        if (int.Parse(command[1]) >= collectionOfNumbers.Count() || int.Parse(command[1]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        collectionOfNumbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Shift":
                        if (command[1] == "left")
                        {
                            for (int i = 0; i < int.Parse(command[2]); i++)
                            {
                                collectionOfNumbers.Add(collectionOfNumbers[0]);
                                collectionOfNumbers.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < int.Parse(command[2]); i++)
                            {
                                collectionOfNumbers.Insert(0, collectionOfNumbers[collectionOfNumbers.Count - 1]);
                                collectionOfNumbers.RemoveAt(collectionOfNumbers.Count - 1);
                            }
                        }
                        break;
                    default:
                        return;
                }
            }
        }
    }
}