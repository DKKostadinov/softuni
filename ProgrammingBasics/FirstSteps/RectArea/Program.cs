using System;

namespace RectArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the sides of the rectangle");
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of the rectangle: " + sideA*sideB);

        }
    }
}
