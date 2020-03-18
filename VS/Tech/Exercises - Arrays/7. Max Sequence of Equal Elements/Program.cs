using System;
using System.Linq;

namespace _7._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int currentStreak = 1;
            int maxStreak = 1;
            int currentStreakValue = inputArray[0];
            int maxStreakValue = inputArray[0];

            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] == inputArray[i - 1])
                {
                    currentStreak++;
                }
                else
                {
                    if (currentStreak > maxStreak)
                    {
                        maxStreak = currentStreak;
                        maxStreakValue = currentStreakValue;
                    }

                    currentStreak = 1;
                    currentStreakValue = inputArray[i];
                }
            }
            if (currentStreak > maxStreak)
            {
                maxStreak = currentStreak;
                maxStreakValue = currentStreakValue;
            }

            for (int i = 0; i < maxStreak; i++)
            {
                Console.Write(maxStreakValue + " ");
            }
            
        }
    }
}
