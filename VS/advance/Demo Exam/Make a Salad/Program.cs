namespace Make_a_Salad
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue<string> vegetables = new Queue<string>();
            List<string> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            foreach (var item in input)
            {
                vegetables.Enqueue(item);
            }
            Stack<int> salads = new Stack<int>();
            input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            foreach (var item in input)
            {
                salads.Push(int.Parse(item));
            }
            List<int> madeSalads = new List<int>();
            while (vegetables.Count > 0 && salads.Count > 0)
            {
                int currentSalad = salads.Peek();
                while (currentSalad > 0 && vegetables.Count > 0)
                {
                    int currentVeg = vegetablesToCalories(vegetables.Dequeue());
                    currentSalad -= currentVeg;
                }
                Console.Write(salads.Pop() + " ");
            }
            Console.WriteLine();
            if (!(vegetables.Count > 0))
            {
                foreach (var item in salads)
                {
                    Console.Write(item + " ");
                }
            }
            if (!(salads.Count > 0))
            {
                foreach (var item in vegetables)
                {
                    Console.Write(item + " ");
                }
            }
        }

        static int vegetablesToCalories(string veg)
        {
            if (veg == "tomato") return 80;
            if (veg == "carrot") return 136;
            if (veg == "lettuce") return 109;
            if (veg == "potato") return 215;
            return 0;
        }
    }
}
