using System;

namespace TopNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            for (int i = 0; i <= end; i++)
            {
                if (ContainsOddDigit(i) && SumOfDigitsIsDivisibleBy8(i)) Console.WriteLine(i);
            }
        }
        static bool ContainsOddDigit(int n)
        {
            if (n.ToString().Contains('1') || n.ToString().Contains('3') || n.ToString().Contains('5') || n.ToString().Contains('7') || n.ToString().Contains('9') )
                return true;
            else return false;
        }
        static bool SumOfDigitsIsDivisibleBy8(int n)
        {
            if (SumOfDigits(n) % 8 == 0) return true;
            else return false;
        }
        static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
