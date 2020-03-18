using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            double result = DivisionOfFactorials(number1, number2);
            Console.WriteLine($"{result:f2}");
        }

        static double DivisionOfFactorials(int number1, int number2)
        {
            double result = 1;
            if (number1 >= number2)
            {
                for (int i = number2 + 1; i <= number1; i++)
                {
                    result *= i;
                }
            }
            else
            {
                for (int i = number1 + 1; i <= number2; i++)
                {
                    result *= i;
                }
                result = 1 / result;
            }
            return result;
        }
    }
}
