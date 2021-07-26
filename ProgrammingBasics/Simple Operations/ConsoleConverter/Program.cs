using System;

namespace ConsoleConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();

            switch (inputCurrency)
            {
                case "BGN":
                    break;
                case "USD":
                    value *= 1.79549;
                    break;
                case "EUR":
                    value *= 1.95583;
                    break;
                case "GBP":
                    value *= 2.53405;
                    break;
                default:
                    break;
            }

            switch (outputCurrency)
            {
                case "BGN":
                    break;
                case "USD":
                    value /= 1.79549;
                    break;
                case "EUR":
                    value /= 1.95583;
                    break;
                case "GBP":
                    value /= 2.53405;
                    break;
                default:
                    break;
            }

            Console.WriteLine(Math.Round(value,2) +" " + outputCurrency);
        }
    }
}
