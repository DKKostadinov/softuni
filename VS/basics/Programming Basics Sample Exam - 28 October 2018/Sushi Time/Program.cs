using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushiType = Console.ReadLine();
            string restaurant = Console.ReadLine();
            int numberOfPortions = int.Parse(Console.ReadLine());
            string confirmation = Console.ReadLine();
            double price = 0;

            switch (sushiType)
            {
                case "sashimi":
                    switch (restaurant)
                    {
                        case "Sushi Zone":
                            price = numberOfPortions * 4.99;
                            break;
                        case "Sushi Time":
                            price = numberOfPortions * 5.49;
                            break;
                        case "Sushi Bar":
                            price = numberOfPortions * 5.25;
                            break;
                        case "Asian Pub":
                            price = numberOfPortions * 4.5;
                            break;
                        default:
                            Console.WriteLine($"{restaurant} is invalid restaurant!");
                            return;
                    }
                    break;
                case "maki":
                    switch (restaurant)
                    {
                        case "Sushi Zone":
                            price = numberOfPortions * 5.29;
                            break;
                        case "Sushi Time":
                            price = numberOfPortions * 4.69;
                            break;
                        case "Sushi Bar":
                            price = numberOfPortions * 5.55;
                            break;
                        case "Asian Pub":
                            price = numberOfPortions * 4.8;
                            break;
                        default:
                            Console.WriteLine($"{restaurant} is invalid restaurant!");
                            return;
                    }
                    break;
                case "uramaki":
                    switch (restaurant)
                    {
                        case "Sushi Zone":
                            price = numberOfPortions * 5.99;
                            break;
                        case "Sushi Time":
                            price = numberOfPortions * 4.49;
                            break;
                        case "Sushi Bar":
                            price = numberOfPortions * 6.25;
                            break;
                        case "Asian Pub":
                            price = numberOfPortions * 5.5;
                            break;
                        default:
                            Console.WriteLine($"{restaurant} is invalid restaurant!");
                            return;
                    }
                    break;
                case "temaki":
                    switch (restaurant)
                    {
                        case "Sushi Zone":
                            price = numberOfPortions * 4.29;
                            break;
                        case "Sushi Time":
                            price = numberOfPortions * 5.19;
                            break;
                        case "Sushi Bar":
                            price = numberOfPortions * 4.75;
                            break;
                        case "Asian Pub":
                            price = numberOfPortions * 5.5;
                            break;
                        default:
                            Console.WriteLine($"{restaurant} is invalid restaurant!");
                            return;
                    }
                    break;
                default:
                    break;
            }

            if(confirmation == "Y")
            {
                Console.WriteLine($"Total price: {Math.Ceiling(price * 1.2)} lv.");
            }
            else Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
        }
    }
}