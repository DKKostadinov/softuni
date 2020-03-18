using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double shipVolume = double.Parse(Console.ReadLine()) * double.Parse(Console.ReadLine()) * double.Parse(Console.ReadLine());
            double avgHeight = double.Parse(Console.ReadLine());
            double neededVolume = 4 * (avgHeight + 0.4);
            int numberOfAstronauts = (int)Math.Floor(shipVolume / neededVolume);
            if (numberOfAstronauts < 3) Console.WriteLine("The spacecraft is too small.");
            else if (numberOfAstronauts < 11) Console.WriteLine($"The spacecraft holds {numberOfAstronauts} astronauts.");
            else Console.WriteLine("The spacecraft is too big.");
        }
    }
}
