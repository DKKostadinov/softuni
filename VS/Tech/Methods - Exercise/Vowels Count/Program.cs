using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfVowelsInString(Console.ReadLine()));
        }

        static int NumberOfVowelsInString(string inputString)
        {
            int numberOfVowels = 0;
            inputString = inputString.ToLower();
            foreach (var letter in inputString)
            {
                if (letter == 'a' || letter == 'e' || letter == 'o' || letter == 'u' || letter == 'i')
                    numberOfVowels++;
            }
            return numberOfVowels;
        }
    }
}
