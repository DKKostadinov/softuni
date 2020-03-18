using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double speed = double.Parse(Console.ReadLine());

            double time = meters * speed + Math.Floor(meters / 15) * 12.5;

            if (recordSeconds - time > 0) Console.WriteLine($"Yes, he succeeded! The new world record is {time:F2} seconds.");
            else Console.WriteLine($"No, he failed! He was {time-recordSeconds:F2} seconds slower.");
        }
    }
}
