using System;
using System.Collections.Generic;
using System.Linq;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfElements = double.Parse(Console.ReadLine());
            List<double> oddElements = new List<double>();
            List<double> evenElements = new List<double>();
            for (int i = 1; i <= numberOfElements ; i++)
            {
                if (i % 2 == 0)
                {
                    evenElements.Add(double.Parse(Console.ReadLine()));
                }
                else
                {
                    oddElements.Add(double.Parse(Console.ReadLine()));
                }
            }
            Console.WriteLine($"OddSum={oddElements.Sum():f2},");
            string oddMin = (oddElements.Count > 0) ? String.Format("{0:0.00}", oddElements.Min()) : "No";
            string oddMax = (oddElements.Count > 0) ? String.Format("{0:0.00}", oddElements.Max()) : "No";
            Console.WriteLine($"OddMin={oddMin},");
            Console.WriteLine($"OddMax={oddMax},");
            Console.WriteLine($"EvenSum={evenElements.Sum():f2},");
            string evenMin = (evenElements.Count > 0) ? String.Format("{0:0.00}", evenElements.Min()) : "No";
            string evenMax = (evenElements.Count > 0) ? String.Format("{0:0.00}", evenElements.Max()) : "No";
            Console.WriteLine($"EvenMin={evenMin},");
            Console.WriteLine($"EvenMax={evenMax}");
        }
    }
}
