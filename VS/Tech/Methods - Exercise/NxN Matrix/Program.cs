using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixPrinter(int.Parse(Console.ReadLine()));
        }

        static void MatrixPrinter(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
