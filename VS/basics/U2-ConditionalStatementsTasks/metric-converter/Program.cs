using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metric_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string firstMetric = Console.ReadLine();
            string secondMetric = Console.ReadLine();
            double finalNum = 0;

            switch (firstMetric)
            {
                case "mm":
                    num /= 1000;
                    break;
                case "cm":
                    num /= 100;
                    break;
                case "mi":
                    num /= 0.000621371192;
                    break;
                case "in":
                    num /= 39.3700787;
                    break;
                case "km":
                    num /= 0.001;
                    break;
                case "ft":
                    num /= 3.2808399;
                    break;
                case "yd":
                    num /= 1.0936133;
                    break;
                default:
                    break;
            }

            switch (secondMetric)
            {
                case "mm":
                    num *= 1000;
                    break;
                case "cm":
                    num *= 100;
                    break;
                case "mi":
                    num *= 0.000621371192;
                    break;
                case "in":
                    num *= 39.3700787;
                    break;
                case "km":
                    num *= 0.001;
                    break;
                case "ft":
                    num *= 3.2808399;
                    break;
                case "yd":
                    num *= 1.0936133;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{num:F8}");
        }
    }
}
