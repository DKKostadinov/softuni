using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            MiddleCharatcerInString(Console.ReadLine());
        }

        static void MiddleCharatcerInString(string input)
        {
            if (input.Length % 2 == 1)
            {
                Console.WriteLine(input[input.Length / 2]);
            }
            else Console.WriteLine(input[input.Length / 2 - 1] + "" +input[input.Length / 2]);
        }
    }
}
