using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            double percPerDancer = stepsPerDay / dancers;

            if (stepsPerDay <= 13) Console.WriteLine($"Yes, they will succeed in that goal! {percPerDancer:F2}%.");
            else Console.WriteLine($"No, They will not succeed in that goal! Required {percPerDancer:F2}% steps to be learned per day.");
        }
    }
}
