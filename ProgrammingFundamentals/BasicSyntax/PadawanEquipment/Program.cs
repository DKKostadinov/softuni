using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            
            double price = numberOfStudents * robePrice +
                Math.Ceiling(numberOfStudents * 1.1) * lightsaberPrice +
                (numberOfStudents - numberOfStudents / 6) * beltPrice;
            if (price > money)
            {
                Console.WriteLine($"John will need {price-money:0.00}lv more.");
            }
            else Console.WriteLine($"The money is enough - it would cost {price:0.00}lv.");

        }
    }
}
