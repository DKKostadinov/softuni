using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHour = int.Parse(Console.ReadLine());
            int startMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());
            
            int timeDifference = (startMinute + startHour * 60) - (arrivalMinute + arrivalHour * 60);
            if (timeDifference < 0)
            {
                Console.WriteLine("Late");
                if (timeDifference > -60) Console.WriteLine($"{Math.Abs(timeDifference)} minutes after the start");
                else
                {

                    timeDifference = Math.Abs(timeDifference);
                    if (timeDifference - (timeDifference / 60) * 60 < 10)
                    {
                        Console.WriteLine($"{timeDifference / 60}:0{timeDifference - (timeDifference / 60) * 60} hours after the start");
                    }
                    else Console.WriteLine($"{timeDifference / 60}:{timeDifference - (timeDifference / 60) * 60} hours after the start");
                }
            }
            else if (timeDifference <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{timeDifference} minutes before the start");
            }
            else
            {
                Console.WriteLine("Early");
                if (timeDifference < 60) Console.WriteLine($"{timeDifference} minutes before the start");
                else if (timeDifference - (timeDifference / 60) * 60 < 10) Console.WriteLine($"{timeDifference/60}:0{timeDifference - (timeDifference/60) * 60} hours before the start");
                else Console.WriteLine($"{timeDifference / 60}:{timeDifference - (timeDifference / 60) * 60} hours before the start");
            }

        }
    }
}
