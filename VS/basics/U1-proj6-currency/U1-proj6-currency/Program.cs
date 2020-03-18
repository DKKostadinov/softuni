using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_proj6_currency
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string firstCurrency = Console.ReadLine();
            string secondCurrency = Console.ReadLine();
            double bgnValue = 0;
            double finalValue = 0;

            switch (firstCurrency)
            {
                case "BGN":
                    bgnValue = value;
                    break;
                case "USD":
                    bgnValue = value * 1.79549;
                    break;
                case "EUR":
                    bgnValue = value * 1.95583;
                    break;
                case "GBP":
                    bgnValue = value * 2.53405;
                    break;
                default:
                    break;
            }

            switch (secondCurrency)
            {
                case "BGN":
                    finalValue = bgnValue;
                    break;
                case "USD":
                    finalValue = bgnValue / 1.79549;
                    break;
                case "EUR":
                    finalValue = bgnValue / 1.95583;
                    break;
                case "GBP":
                    finalValue = bgnValue / 2.53405;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{finalValue:F2}");
        }
    }
}
