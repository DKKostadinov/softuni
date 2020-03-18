using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double price = Math.Ceiling(numberOfStudents * 1.1) * lightsaberPrice
                + numberOfStudents * robePrice + beltPrice * (numberOfStudents - numberOfStudents / 6); ;

            if (cash - price >= 0) Console.WriteLine($"The money is enough - it would cost {price:f2}lv.");
            else Console.WriteLine($"Ivan Cho will need {price - cash :f2}lv more.");
        }
    }
}
