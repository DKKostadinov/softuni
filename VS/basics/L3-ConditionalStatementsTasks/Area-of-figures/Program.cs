using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double size1;
            double size2;
            double area = 0;

            switch (figure)
            {
                case "square":
                    size1 = double.Parse(Console.ReadLine());
                    area = Math.Pow(size1, 2);
                    break;
                case "rectangle":
                    size1 = double.Parse(Console.ReadLine());
                    size2 = double.Parse(Console.ReadLine());
                    area = size1 * size2;
                    break;
                case "circle":
                    size1 = double.Parse(Console.ReadLine());
                    area = Math.PI * Math.Pow(size1, 2);
                    break;
                case "triangle":
                    size1 = double.Parse(Console.ReadLine());
                    size2 = double.Parse(Console.ReadLine());
                    area = (size1 * size2) / 2;
                    break;
            }
            Console.WriteLine($"{area:F3}");
        }
    }
}
