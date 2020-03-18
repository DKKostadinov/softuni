using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = string.Empty;
            while (true)
            {
                inputNumber = Console.ReadLine();
                if (inputNumber.Equals("END"))
                    break;
                if (inputNumber.Equals(ReverseString(inputNumber)))
                    Console.WriteLine("true");
                else
                    Console.WriteLine("false");
                
            }
        }

        static string ReverseString(string inputString)
        {
            char[] arrayString = inputString.ToCharArray();
            Array.Reverse(arrayString);
            return new string(arrayString);
        }
    }
}
