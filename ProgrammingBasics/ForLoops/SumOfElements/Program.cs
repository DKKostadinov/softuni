using System;

namespace SumOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int elements = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int biggestElement = 0;
            for (int i = 0; i < elements; i++)
            {
                int input = int.Parse(Console.ReadLine());
                totalSum += input;
                biggestElement = (input > biggestElement) ? input : biggestElement;
            }
            if (biggestElement == totalSum - biggestElement)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {totalSum - biggestElement}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(totalSum - 2*biggestElement)}");
            }
        }
    }
}
