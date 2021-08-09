using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfVowels(Console.ReadLine()));
        }

        static int NumberOfVowels(string text)
        {
            text = text.ToLower();
            int numberOfVolews = 0;
            foreach (var symbol in text)
            {
                if (symbol == 'a' || symbol == 'e' || symbol == 'u' || symbol == 'o' || symbol == 'i') numberOfVolews++;
            }
            return numberOfVolews;
        }
    }
}
