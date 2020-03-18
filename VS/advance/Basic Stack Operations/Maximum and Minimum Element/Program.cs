using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < N; i++)
            {
                List<int> input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

                switch (input[0])
                {
                    case 1:
                        int element = input[1];
                        stack.Push(element);
                        break;
                    case 2:
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            list = stack.OrderBy(x => x).ToList();
                            Console.WriteLine(list[list.Count - 1]);
                        }
                        break;
                    case 4:
                        if (stack.Count > 0)
                        {
                            list = stack.OrderBy(x => x).ToList();
                            Console.WriteLine(list[0]);
                        }
                        break;
                    default:
                        break;
                }
            }
            }
            
            int j = stack.Count;
            for (int i = 0; i < j; i++)
            {
                if (stack.Count == 1)
                {
                    Console.Write(stack.Pop());
                }
                else
                {
                    Console.Write(stack.Pop() + ", ");
                }
            }
        }
    }
}
