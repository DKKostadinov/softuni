using System;

namespace Divisions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int dividable = 0;
            if (number % 10 == 0)
            {
                dividable = 10;
            }
            else if (number % 7 == 0)
            {
                dividable = 7;
            }
            else if (number % 6 == 0)
            {
                dividable = 6;
            }
            else if (number % 3 == 0)
            {
                dividable = 3;
            }
            else if (number % 2 == 0)
            {
                dividable = 2;
            }
            else
            {
                Console.WriteLine("Not divisible");
                return;
            }
            Console.WriteLine($"The number is divisible by {dividable}");
        }
    }
}
