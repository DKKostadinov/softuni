using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
•	Add { number} – add number at the end.
•	Insert { number}
            { index} – insert number at given index.
•	Remove { index} – remove at index.
•	Shift left { count} – first number becomes last ‘count’ times.
•	Shift right { count} – last number becomes first ‘count’ times.*/

            List<int> numbers = Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
            while (true)
            {
                List<string> input = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                switch (input[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(input[1]));
                        break;
                    case "Insert":
                        if(int.Parse(input[2]) >= 0 && int.Parse(input[2]) < numbers.Count) numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                        else Console.WriteLine("Invalid index");
                        break;
                    case "Remove":
                        if (int.Parse(input[1]) >= 0 && int.Parse(input[1]) < numbers.Count) numbers.RemoveAt(int.Parse(input[1]));
                        else Console.WriteLine("Invalid index");
                        break;
                    case "Shift":
                        int n = int.Parse(input[2]);
                        for (int i = 0; i < n; i++)
                        {
                            if (input.Contains("left"))
                            {
                                int num = numbers[0];
                                numbers.RemoveAt(0);
                                numbers.Add(num);
                            }
                            else
                            {
                                int num = numbers.Last();
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.Insert(0, num);
                            }
                        }
                        break;
                    case "End":
                        Console.WriteLine(String.Join(" ", numbers));
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
