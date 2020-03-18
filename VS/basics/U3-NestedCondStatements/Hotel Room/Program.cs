using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsStaying = int.Parse(Console.ReadLine());
            double priceForStudio = -1;
            double priceForApartment = -1;

            switch (month)
            {
                case "May":
                case "Ocotber":
                    priceForStudio = nightsStaying * 50;
                    if (nightsStaying > 14) priceForStudio *= 0.70;
                    else if (nightsStaying > 7) priceForStudio *= 0.95;
                    priceForApartment = nightsStaying * 65;
                    break;
                case "June":
                case "September":
                    priceForStudio = nightsStaying * 75.20;
                    if (nightsStaying > 14) priceForStudio *= 0.80;
                    priceForApartment = nightsStaying * 68.70;
                    break;
                case "July":
                case "August":
                    priceForStudio = nightsStaying * 76;
                    priceForApartment = nightsStaying * 77;
                    break;
                default:
                    break;
            }
            if (nightsStaying > 14) priceForApartment *= 0.90;
            Console.WriteLine($"Apartment: {priceForApartment:f2} lv.\nStudio: {priceForStudio:f2} lv.");
        }
    }
}