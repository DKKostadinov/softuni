using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_proj3_dance
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double side = double.Parse(Console.ReadLine());
            double area = lenght * width * 10000;
            double areaWardrobe = side * side * 10000;
            double areaBench = area / 10;
            Console.WriteLine(Math.Floor((area - areaBench - areaWardrobe) / 7040));
        }
    }
}
