using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfYear = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekends = int.Parse(Console.ReadLine());
            double volleyballDays = 0;

            switch (typeOfYear)
            {
                case "normal":
                    volleyballDays = 0.75 * (48 - weekends) + weekends + holidays * (2.0 / 3);
                    break;
                case "leap":
                    volleyballDays = 0.75 * (48 - weekends) + weekends + holidays * (2.0 / 3);
                    volleyballDays *= 1.15;
                    break;
                default:
                    break;
            }
            Console.WriteLine(Math.Floor(volleyballDays));
        }
    }
}
