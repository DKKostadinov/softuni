using System;

namespace Tailors
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfOrder = int.Parse(Console.ReadLine());
            var sideA = double.Parse(Console.ReadLine());
            var sideB = double.Parse(Console.ReadLine());

            var priceForSquare = Math.Pow((sideA / 2), 2) * 9;
            var priceForRect = (sideA + 0.60) * (sideB + 0.60) * 7;
            Console.WriteLine(Math.Round(numberOfOrder * (priceForRect + priceForSquare), 2) + " USD");
            Console.WriteLine(Math.Round(numberOfOrder * (priceForRect + priceForSquare) * 1.85, 2) + " BGN");

        }
    }
}
