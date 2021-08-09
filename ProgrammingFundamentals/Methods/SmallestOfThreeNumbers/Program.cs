using System;
using System.Linq;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestOfThreeNumbers(a,b,c));
        }

        static int SmallestOfThreeNumbers(int a, int b, int c)
        {
            int[] array = new int[] { a, b, c };
            return array.Min();
        }
    }
}
