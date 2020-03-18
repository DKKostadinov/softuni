namespace Spaceship_Crafting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            //first
            List<int> liquids = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            //last
            List<int> solids = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int glassNum = 0;
            int alumNum = 0;
            int lithNum = 0;
            int carbonNum = 0;

            while (liquids.Count > 0 && solids.Count > 0)
            {
                int currentLiquid = liquids.First();
                int currentSolid = solids.Last();
                int sum = currentLiquid + currentSolid;

                if (sum == 25)
                {
                    glassNum++;
                    liquids.RemoveAt(0);
                    solids.RemoveAt(solids.Count - 1);
                }
                else if (sum == 50)
                {
                    alumNum++;
                    liquids.RemoveAt(0);
                    solids.RemoveAt(solids.Count - 1);
                }
                else if (sum == 75)
                {
                    lithNum++;
                    liquids.RemoveAt(0);
                    solids.RemoveAt(solids.Count - 1);
                }
                else if (sum == 100)
                {
                    carbonNum++;
                    liquids.RemoveAt(0);
                    solids.RemoveAt(solids.Count - 1);
                }
                else
                {
                    liquids.RemoveAt(0);
                    solids[solids.Count - 1] += 3;
                }
            }

            if (alumNum > 0 && lithNum > 0 && glassNum > 0 && carbonNum > 0)
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            else
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");

            Console.Write("Liquids left: ");
            if (liquids.Count > 0)
                Console.WriteLine(string.Join(", ", liquids));
            else
                Console.WriteLine("none");

            solids.Reverse();
            Console.Write("Physical items left: ");
            if (solids.Count > 0)
                Console.WriteLine(string.Join(", ", solids));
            else
                Console.WriteLine("none");

            Console.WriteLine($"Aluminium: {alumNum}");
            Console.WriteLine($"Carbon fiber: {carbonNum}");
            Console.WriteLine($"Glass: {glassNum}");
            Console.WriteLine($"Lithium: {lithNum}");
        }
    }
}
