using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Bros
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBro = double.Parse(Console.ReadLine());
            double secondBro = double.Parse(Console.ReadLine());
            double thirdBro = double.Parse(Console.ReadLine());
            double dad = double.Parse(Console.ReadLine());

            double cleaningTime = (1 / (1/firstBro + 1/secondBro + 1/thirdBro)) * 1.15;

            Console.WriteLine($"Cleaning time: {cleaningTime:F2}");
            if (dad - cleaningTime >= 0)
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(dad - cleaningTime)} hours.");
            else
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(cleaningTime - dad)} hours.");
        }
    }
}
