using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = 1000000000;
            double oddMax = -1000000000;
            double evenSum = 0;
            double evenMin = 1000000000;
            double evenMax = -1000000000;
            double num = 0;

            for (int i = 1; i <= n; i++)
            {
                num = double.Parse(Console.ReadLine());
                if(i % 2 == 0)
                {
                    evenSum += num;
                    evenMax = (num > evenMax) ? num : evenMax;
                    evenMin = (num < evenMin) ? num : evenMin;
                }
                else
                {
                    oddSum += num;
                    oddMax = (num > oddMax) ? num : oddMax;
                    oddMin = (num < oddMin) ? num : oddMin;
                }
            }

            Console.WriteLine($"OddSum={oddSum},");
            if (oddMin != 1000000000) Console.WriteLine($"OddMin={oddMin},");
            else Console.WriteLine($"OddMin=No,");
            if (oddMax != -1000000000) Console.WriteLine($"OddMax={oddMax},");
            else Console.WriteLine($"OddMax=No,");
            Console.WriteLine($"EvenSum={evenSum},");
            if (evenMin != 1000000000) Console.WriteLine($"EvenMin={evenMin},");
            else Console.WriteLine($"EvenMin=No,");
            if (evenMax != -1000000000) Console.WriteLine($"EvenMax={evenMax},");
            else Console.WriteLine($"EvenMax=No,");
        }
    }
}
