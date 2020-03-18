using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    class Program
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int N = input[0];
            int S = input[1];
            int X = input[2];
            int smallestElement = int.MaxValue;
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Queue<int> numberStack = new Queue<int>();
            for (int i = 0; i < N; i++)
            {
                numberStack.Enqueue(numbers[i]);
            }
            for (int i = 0; i < S; i++)
            {
                numberStack.Dequeue();
            }
            if (numberStack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            while (numberStack.Count > 0)
            {
                int number = numberStack.Dequeue();
                if (number == X)
                {
                    Console.WriteLine("true");
                    return;
                }
                if (number < smallestElement)
                {
                    smallestElement = number;
                }
            }
            Console.WriteLine(smallestElement);
        }
    }
}
