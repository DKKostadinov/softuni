using System;

namespace RectAreaCoords
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double sideX = Math.Abs(x1 - x2);
            double sideY = Math.Abs(y1 - y2);
            double Area = sideX * sideY;
            double Perimeter = 2 * (sideX + sideY);

            Console.WriteLine(Area);
            Console.WriteLine(Perimeter);
        }
    }
}
