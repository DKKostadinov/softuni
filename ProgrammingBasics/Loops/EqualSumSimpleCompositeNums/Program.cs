using System;

namespace EqualSumPrimeCompositeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0;
            int compSum = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop") break;
                if (int.Parse(input) < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(int.Parse(input))+1; i++)
                {
                    if (int.Parse(input) % i == 0) isPrime = false;
                }
                if (isPrime) primeSum += int.Parse(input);
                else compSum += int.Parse(input);
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {compSum}");
        }
    }
}
