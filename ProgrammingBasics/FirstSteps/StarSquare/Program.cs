using System;

namespace StarSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());
            for (int i = 0; i < side; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 0; i < side-2; i++)
            {
                Console.Write("*");
                for (int j = 0; j < side-2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            for (int i = 0; i < side; i++)
            {
                Console.Write("*");
            }
        }
    }
}
