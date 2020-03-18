using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {

            int primeSum = 0;
            int nonPrimeSum = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop") break;
                else if (int.Parse(input) < 0) Console.WriteLine("Number is negative.");
                else
                {
                    int flag = 0;
                    int number = int.Parse(input);
                    for (int i = 2; i < number; i++)
                    {
                        if (number % i == 0) flag = 1;
                    }
                    if (flag == 0) primeSum += number;
                    else nonPrimeSum += number;
                }

            }
            Console.WriteLine("Sum of all prime numbers is: " + primeSum);
            Console.WriteLine("Sum of all non prime numbers is: " + nonPrimeSum);
        }
    }
}