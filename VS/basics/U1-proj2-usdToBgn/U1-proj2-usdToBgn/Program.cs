using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_proj2_usdToBgn
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double price1 = count * (length + 0.6) * (width + 0.6);
            double price2 = count * (length / 2) * (length / 2);
            double priceUSD = price1 * 7 + price2 * 9;
            double priceBGN = priceUSD * 1.85;
            Console.WriteLine($"{priceUSD:F2} USD");
            Console.WriteLine($"{priceBGN:F2} BGN");
        }
    }
}
