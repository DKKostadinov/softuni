using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            double profit = 0;

            switch (projection)
            {
                case "Premiere":
                    profit = row * column * 12;
                    break;
                case "Normal":
                    profit = row * column * 7.50;
                    break;
                case "Discount":
                    profit = row * column * 5;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{profit:f2} leva");
        }
    }
}
