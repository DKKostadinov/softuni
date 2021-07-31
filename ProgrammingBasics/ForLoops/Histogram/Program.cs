using System;
using System.Collections.Generic;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lessThan200 = new List<int>();
            List<int> to399 = new List<int>();
            List<int> to599 = new List<int>();
            List<int> to799 = new List<int>();
            List<int> moreThan799 = new List<int>();
            int numberOfNumbers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfNumbers; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input < 200)
                {
                    lessThan200.Add(input);
                }
                else if (input < 400)
                {
                    to399.Add(input);
                }
                else if (input < 600)
                {
                    to599.Add(input);
                }
                else if (input < 800)
                {
                    to799.Add(input);
                }
                else
                {
                    moreThan799.Add(input);
                }
            }
            Console.WriteLine($"{(double)lessThan200.Count/numberOfNumbers*100:f2}%\n{(double)to399.Count / numberOfNumbers * 100:f2}%\n{(double)to599.Count / numberOfNumbers * 100:f2}%\n{(double)to799.Count / numberOfNumbers * 100:f2}%\n{(double)moreThan799.Count / numberOfNumbers * 100:f2}%");
        }
    }
}
