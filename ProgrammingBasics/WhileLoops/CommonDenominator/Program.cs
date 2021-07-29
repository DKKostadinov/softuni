using System;

namespace CommonDenominator
{
    class Program
    {
        static void Main(string[] args)
        {
            uint a = uint.Parse(Console.ReadLine());
            uint b = uint.Parse(Console.ReadLine());
            var biggestCommon = 0;
            var i = 0;
            while ( i < a && i < b)
            {
                i++;
                if(a % i == 0 && b % i == 0)
                {
                    biggestCommon = i;
                }
            }
            Console.WriteLine(biggestCommon);
        }
    }
}
