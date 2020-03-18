using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodStorage = int.Parse(Console.ReadLine());
            int sum = 0;
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Console.WriteLine(orders.Max());
            while (orders.Count > 0)
            {
                sum += orders.Peek();
                if (foodStorage - sum < 0)
                {
                    int[] arr = orders.ToArray();
                    Console.WriteLine("Orders left: " + string.Join(" ", arr));
                    return;
                }
                else
                {
                    orders.Dequeue();
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
