using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SmallestNumberOfThree(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }

        static int SmallestNumberOfThree(int number1, int number2, int number3)
        {
            if (number1 < number2 && number1 <= number3)
            {
                return number1;                   
            }
            if (number2 < number1 && number2 <= number3)
            {
                return number2;
            }
            if (number3 < number2 && number3 <= number1)
            {
                return number3;
            }
            return number1;
        }
    }
}
