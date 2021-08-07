using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            double sum = 0;
            foreach (var digit in number)
            {
                sum += Char.GetNumericValue(digit);
            }
            Console.WriteLine(sum);
        }
    }
}
