using System;
using System.Collections.Generic;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int div2 = 0;
            int div3 = 0;
            int div4 = 0;
            int numberOfNumbers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfNumbers; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input % 2 == 0)
                {
                    div2++;
                }
                if (input % 3 == 0)
                {
                    div3++;
                }
                if (input % 4 == 0)
                {
                    div4++;
                }
            }
            Console.WriteLine($"{(double)div2/numberOfNumbers*100:f2}%\n{(double)div3 / numberOfNumbers * 100:f2}%\n{(double)div4 / numberOfNumbers * 100:f2}%");    
        }
    }
}