using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSymbols = int.Parse(Console.ReadLine());
            string msg = "";
            for (int i = 0; i < numberOfSymbols; i++)
            {
                int number = int.Parse(Console.ReadLine());
                char letter = NumberToLetter(number);
                msg += letter;
            }
            Console.WriteLine(msg);
        }

        static char NumberToLetter(int number)
        {
            if (number == 0) return ' ';
            int numberOfDigits = number.ToString().Length;
            int mainDigit = number % 10;
            int offset = (mainDigit - 2) * 3;
            offset = (mainDigit == 7 || mainDigit == 9) ? offset + 1 : offset;
            int letterIndex = offset + numberOfDigits - 1;
            return (char)('a' + letterIndex);
        }
    }
}
