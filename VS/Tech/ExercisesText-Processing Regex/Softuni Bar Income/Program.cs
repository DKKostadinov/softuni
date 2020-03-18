using System;
using System.Text.RegularExpressions;

namespace Softuni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[^%|$.]*%(?<customer>[A-Z][a-z]+)%[^%|$.]*<(?<product>\w+)>[^%|$.]*\|(?<count>\d+)\|[^%|$.]*?(?<price>\+*\-*\d+.?\d+)\$$";
            string input = string.Empty;
            double totalIncome = 0.0;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Regex order = new Regex(pattern);
                if (order.IsMatch(input))
                {
                    string customer = order.Match(input).Groups["customer"].Value;
                    string product = order.Match(input).Groups["product"].Value;
                    int count = int.Parse(order.Match(input).Groups["count"].Value);
                    double price = double.Parse(order.Match(input).Groups["price"].Value);
                    Console.WriteLine($"{customer}: {product} - {price*count:f2}");
                    totalIncome += price * count;
                }
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
