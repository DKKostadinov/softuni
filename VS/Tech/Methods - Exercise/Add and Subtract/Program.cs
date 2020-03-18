using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Subtract(Sum(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())), int.Parse(Console.ReadLine())));
        }

        static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        static int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
