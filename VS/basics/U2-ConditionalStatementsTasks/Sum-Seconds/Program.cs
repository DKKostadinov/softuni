using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());
            int timeInSeconds = time1 + time2 + time3;
            int minutes = timeInSeconds / 60;
            int seconds = timeInSeconds - minutes * 60;
            if(seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else Console.WriteLine($"{minutes}:{seconds}");
        }
    }
}
