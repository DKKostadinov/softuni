using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double barSide = double.Parse(Console.ReadLine());

            double numberOfPeople = Math.Ceiling((0.81*(length * width) - barSide * barSide) / 3.2);
            Console.WriteLine(numberOfPeople);
        }
    }
}
