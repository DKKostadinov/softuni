using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace decipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex token = new Regex(@"^[d-z#{}|]+$");
            string input = Console.ReadLine();
            string substringInput = Console.ReadLine();
            string substring = substringInput.Split()[0];
            string replacementSubstring = substringInput.Split()[1];

            if (token.IsMatch(input))
            {
                char[] inputChars = input.ToCharArray();
                for (int i = 0; i < inputChars.Length; i++)
                {
                    inputChars[i] = (char)(inputChars[i] - 3);
                }
                input = string.Empty;
                foreach (var item in inputChars)
                {
                    input += item;
                }
                input = input.Replace(substring, replacementSubstring);
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
        }
    }
}
