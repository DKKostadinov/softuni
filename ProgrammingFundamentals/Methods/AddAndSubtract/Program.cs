using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(Sub(Sum(a,b),c));
        }
        static double Sum(double a, double b)
        {
            return a + b;
        }

        static double Sub(double a, double b)
        {
            return a - b;
        }
    }
}
