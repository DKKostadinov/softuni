using System;

namespace Encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int length = num.ToString().Length;
            for (int i = 0; i < length; i++)
            {
                if (num % 10 == 0)
                {
                    Console.Write("ZERO");
                }
                else
                {
                    for (int j = 0; j < num % 10; j++)
                    {

                        Console.Write((char)(num % 10 + 33));
                    }
                }
                num /= 10;
                Console.WriteLine();
            }
        }
    }
}
