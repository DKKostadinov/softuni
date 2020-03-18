using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlower = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;

            switch (typeOfFlower)
            {
                case "Roses":
                    price = (numberOfFlowers > 80) ? (numberOfFlowers * 5) * 0.9 : (numberOfFlowers * 5);
                    break;
                case "Dahlias":
                    price = (numberOfFlowers > 90) ? (numberOfFlowers * 3.8) * 0.85 : (numberOfFlowers * 3.8);
                    break;
                case "Tulips":
                    price = (numberOfFlowers > 80) ? (numberOfFlowers * 2.80) * 0.85 : (numberOfFlowers * 2.80);
                    break;
                case "Narcissus":
                    price = (numberOfFlowers < 120) ? (numberOfFlowers * 3) * 1.15 : (numberOfFlowers * 3);
                    break;
                case "Gladiolus":
                    price = (numberOfFlowers < 80) ? (numberOfFlowers * 2.5) * 1.20 : (numberOfFlowers * 2.5);
                    break;
                default:
                    break;
            }

            if (budget - price >= 0) Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlower} and {(budget - price):f2} leva left.");
            else Console.WriteLine($"Not enough money, you need {(price - budget):f2} leva more.");
        }
    }
}
