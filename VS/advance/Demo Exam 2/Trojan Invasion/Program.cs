namespace Trojan_Invasion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfWaves = int.Parse(Console.ReadLine());
            List<int> plates = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> warrs = new List<int>();
            for (int i = 1; i <= numberOfWaves; i++)
            {
                warrs = Add(warrs, Console.ReadLine());
                if (i % 3 == 0)
                    plates = Add(plates, Console.ReadLine());
                while (warrs.Count > 0 && plates.Count > 0)
                {
                    int currentWarr = warrs.Last();
                    int currentPlate = plates.First();

                    if (currentPlate > currentWarr)
                    {
                        plates[0] -= currentWarr;
                        warrs.RemoveAt(warrs.Count - 1);
                    }
                    else if (currentPlate < currentWarr)
                    {
                        warrs[warrs.Count - 1] -= currentPlate;
                        plates.RemoveAt(0);
                    }
                    else if (currentWarr == currentPlate)
                    {
                        warrs.RemoveAt(warrs.Count - 1);
                        plates.RemoveAt(0);
                    }
                }
                if (plates.Count < 1)
                    break;
            }
            if (plates.Count == 0)
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                warrs.Reverse();
                Console.WriteLine($"Warriors left: {string.Join(", ", warrs)}");
            }
            else if (warrs.Count == 0)
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
        }

        private static List<int> Add(List<int> list, string input)
        {
            List<int> toAdd = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            foreach (var item in toAdd)
            {
                list.Add(item);
            }
            return list;
        }
    }
}
