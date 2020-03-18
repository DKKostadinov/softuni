using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 15;
            if (minutes > 59)
            {
                hour++;
                if (hour == 24) hour = 0;
                minutes -= 60;
            }
            if (minutes < 10) Console.WriteLine($"{hour}:0{minutes}");
            else Console.WriteLine($"{hour}:{minutes}");
        }
    }
}
