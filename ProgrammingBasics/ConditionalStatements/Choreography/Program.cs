using System;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());

            double stepsPerDay = Math.Ceiling(100 / days);
            double stepsPerDancer = stepsPerDay / dancers;
            
            if (stepsPerDay <= 13)
            {
                Console.WriteLine("Yes, they will succeed in that goal! "+ Math.Round(stepsPerDancer, 2) + "%.");
            }
            else
            {
                Console.WriteLine("No, they will not succeed in that goal! Required "+ Math.Round(stepsPerDancer, 2) + "% steps to be learned per day.");
            }
        }
    }
}
