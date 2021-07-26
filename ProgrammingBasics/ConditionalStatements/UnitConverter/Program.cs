using System;

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            switch (inputUnit)
            {
                case "m":
                    break;
                case "mm":
                    value /= 1000;
                    break;
                case "cm":
                    value /= 100;
                    break;
                case "mi":
                    value /= 0.000621371192;
                    break;
                case "in":
                    value /= 39.3700787;
                    break;
                case "km":
                    value /= 0.001;
                    break;
                case "ft":
                    value /= 3.2808399;
                    break;
                case "yd":
                    value /= 1.0936133;
                    break;
                default:
                    break;
            }

            switch (outputUnit)
            {
                case "m":
                    break;
                case "mm":
                    value *= 1000;
                    break;
                case "cm":
                    value *= 100;
                    break;
                case "mi":
                    value *= 0.000621371192;
                    break;
                case "in":
                    value *= 39.3700787;
                    break;
                case "km":
                    value *= 0.001;
                    break;
                case "ft":
                    value *= 3.2808399;
                    break;
                case "yd":
                    value *= 1.0936133;
                    break;
                default:
                    break;
            }

            Console.WriteLine(Math.Round(value, 8));
        }
    }
}
