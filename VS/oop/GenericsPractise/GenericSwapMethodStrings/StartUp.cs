using System;
using System.Linq;

namespace GenericSwapMethodStringsOrInts
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            var listOfBoxes = new BoxList<int>();
            for (int i = 0; i < numberOfStrings; i++)
            {
                listOfBoxes.Add(int.Parse(Console.ReadLine()));
            }

            int[] swapIndexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            listOfBoxes.Swap(swapIndexes[0], swapIndexes[1]);

            Console.WriteLine(listOfBoxes.ToString());
        }
    }
}
