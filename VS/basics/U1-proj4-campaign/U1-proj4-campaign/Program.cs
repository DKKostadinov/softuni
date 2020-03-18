using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_proj4_campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            double dailyCash = bakers * ((cakes * 45) + (waffles * 5.80) + (pancakes * 3.20));
            double totalCash = dailyCash * days;
            double cashAfterTax = totalCash - totalCash / 8;
            Console.WriteLine($"{cashAfterTax:F2}");
        }
    }
}
