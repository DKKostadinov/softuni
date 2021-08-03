using System;
using System.Collections.Generic;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 0;
            foreach (var digit in number)
            {
                int factorialValue = Factorial(int.Parse(digit.ToString()));
                sum += factorialValue;
            }
            if (sum == int.Parse(number)) Console.WriteLine("yes");
            else Console.WriteLine("no");

        }

        static int Factorial(int digit)
        {
            if (digit == 0) return 1;
            return digit * Factorial(digit - 1);
        }
    }
}
