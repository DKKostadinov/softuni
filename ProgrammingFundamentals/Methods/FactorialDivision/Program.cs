using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{(double)(Factorial(int.Parse(Console.ReadLine()))) / (double)(Factorial(int.Parse(Console.ReadLine()))):0.00}");
        }
        static int Factorial(int n)
        {
            if (n < 0) return 1;
            if (n == 0) return 1;
            else return n * (Factorial(n - 1));
        }
    }
}
