using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double cashForGas = 54.39;
            double foodCash = 3 * double.Parse(Console.ReadLine());
            double souvenirCash = 3 * double.Parse(Console.ReadLine());
            double hotelCash = double.Parse(Console.ReadLine());
            hotelCash = 0.9 * hotelCash + 0.85 * hotelCash + 0.8 * hotelCash;
            Console.WriteLine($"Money needed: {(cashForGas + foodCash + souvenirCash + hotelCash):f2}");
        }
    }
}
