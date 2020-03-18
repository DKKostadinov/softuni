using System;

namespace Generating01Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < Math.Pow(2, n); i++)
            {
                DecToBinary(i, n - 1);
                Console.WriteLine();
            }
        }

        static void DecToBinary(int number, int power)
        {
            if (power < 0)
                return;
            if (number - Math.Pow(2, power) >= 0)
            {
                Console.Write(1);
                DecToBinary(number - (int)(Math.Pow(2, power)), power - 1);
            }
            else
            {
                Console.Write(0);
                DecToBinary(number, power - 1);
            }
        }
    }
}
