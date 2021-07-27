using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
            switch (flower)
            {
                case "Roses":
                    price = 5 * numberOfFlowers;
                    if (numberOfFlowers > 80) price *= 0.9;
                    break;
                case "Dahlias":
                    price = 3.80 * numberOfFlowers;
                    if (numberOfFlowers > 90) price *= 0.85;
                    break;
                case "Tulips":
                    price = 2.80 * numberOfFlowers;
                    if (numberOfFlowers > 80) price *= 0.85;
                    break;
                case "Narcissus":
                    price = 3 * numberOfFlowers;
                    if (numberOfFlowers < 120) price *= 1.15;
                    break;
                case "Gladiolus":
                    price = 2.5 * numberOfFlowers;
                    if (numberOfFlowers < 80) price *= 1.2;
                    break;
                default:
                    break;
            }

            if (budget >= price) Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flower} and {String.Format("{0:0.00}", budget - price)} leva left.");
            else Console.WriteLine($"Not enough money, you need {String.Format("{0:0.00}", price-budget)} leva more.");
        }
    }
}
