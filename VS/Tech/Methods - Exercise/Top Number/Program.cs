using System;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= inputNumber; i++)
            {
                if (IsTopNumber(i)) Console.WriteLine(i);
            }
        }

        static bool IsTopNumber(int number)
        {
            if (HasOneOddDigit(number) && SumOfDigits(number) % 8 == 0) return true;
            return false;
        }

        static bool HasOneOddDigit(int number)
        {
            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;
                if (digit % 2 == 1)
                    return true;
            }
            return false;
        }

        static int SumOfDigits (int number)
        {
            int sumOfDigits = 0;
            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;
                sumOfDigits += digit;
            }
            return sumOfDigits;
        }
    }
}
