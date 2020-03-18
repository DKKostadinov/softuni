using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_proj9_birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double perc = double.Parse(Console.ReadLine());

            double volumeInLiters = (a * b * h) * 0.001;
            double finalPerc = perc * 0.01;

            double water = volumeInLiters * (1 - finalPerc);
            Console.WriteLine($"{water:F3}");

        }
    }
}
