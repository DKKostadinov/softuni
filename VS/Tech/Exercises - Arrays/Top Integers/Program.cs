using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            for (int i = 0; i < inputArray.Length; i++)
            {
                bool isBigNumber = true;
                for (int j = ((inputArray.Length) - 1); j > i; j--)
                {
                    if (inputArray[i] <= inputArray[j])
                    {
                        isBigNumber = false;
                        break;
                    }
                }
                if (isBigNumber == true)
                {
                    Console.Write(inputArray[i] + " ");
                }
            }
        }
    }
}
