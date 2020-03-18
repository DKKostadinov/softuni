using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {

            int peopleNumber = int.Parse(Console.ReadLine());
            string peopleType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;

            switch (peopleType)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                        default:
                            break;
                    }
                    price *= peopleNumber;
                    if (peopleNumber >= 30) price *= 0.85;
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16;
                            break;
                        default:
                            break;
                    }
                    if (peopleNumber >= 100) peopleNumber -= 10;
                    price *= peopleNumber;
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 15;
                            break;
                        case "Saturday":
                            price = 20;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                        default:
                            break;
                    }
                    price *= peopleNumber;
                    if (peopleNumber >= 10 && peopleNumber <= 20) price *= 0.95; 
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Total price: {price:f2}");

        }
    }
}
