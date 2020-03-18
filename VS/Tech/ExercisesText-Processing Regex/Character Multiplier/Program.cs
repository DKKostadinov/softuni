using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            Console.WriteLine(CharacterMultiplier(tokens[0], tokens[1]));
        }

        static int CharacterMultiplier(string firstString, string secondString)
        {
            int sum = 0;
            int loopMultiplyLoop = (firstString.Length <= secondString.Length) ? firstString.Length : secondString.Length;
            int loopAddLoop = (firstString.Length >= secondString.Length) ? firstString.Length : secondString.Length;
            for (int i = 0; i < loopMultiplyLoop; i++)
            {
                sum += firstString[i] * secondString[i];
            }
            for (int i = loopMultiplyLoop; i < loopAddLoop; i++)
            {
                if (firstString.Length > secondString.Length)
                    sum += firstString[i];
                else
                    sum += secondString[i];
            }
            return sum;
        }
    }
}
