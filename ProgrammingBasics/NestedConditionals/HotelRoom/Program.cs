using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceForAp = 0;
            double priceForSt = 0;

            if (month == "May" || month == "October")
            {
                priceForAp = 65;
                priceForSt = 50;
                if (nights > 14)
                {
                    priceForSt *= 0.7;
                }
                else if (nights > 7)
                {
                    priceForSt *= 0.95;
                }
            }
            if (month == "June" || month == "September")
            {
                priceForSt = 75.20;
                priceForAp = 68.70;
                if (nights > 14)
                {
                    priceForSt *= 0.8;
                }
            }
            if (month == "July" || month == "August")
            {
                priceForAp = 77;
                priceForSt = 76;
            }
            if (nights > 14)
            {
                priceForAp *= 0.9;
            }

            Console.WriteLine($"Apartment: {priceForAp*nights:f2} lv.");
            Console.WriteLine($"Studio: {priceForSt*nights:f2} lv.");
        }
    }
}
