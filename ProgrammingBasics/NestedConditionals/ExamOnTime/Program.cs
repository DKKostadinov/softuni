using System;

namespace ExamOnTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine()) + examHour * 60;
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMin = int.Parse(Console.ReadLine()) + arriveHour * 60;

            int timeDiff = examMin - arriveMin;
            if (timeDiff < 0)
            {
                Console.WriteLine("Late");
                timeDiff = Math.Abs(timeDiff);
                if (timeDiff / 60 > 0)
                {
                    if (timeDiff - timeDiff / 60 * 60 < 10)
                    {
                        Console.WriteLine($"{timeDiff/60}:0{timeDiff - timeDiff/60*60} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{timeDiff / 60}:{timeDiff - timeDiff / 60 *60} hours after the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{timeDiff} minutes after the start");
                }
            }
            else if (timeDiff <= 30)
            {
                Console.WriteLine("On time");
                if (timeDiff == 0)
                {

                }
                else
                {
                    if (timeDiff / 60 > 0)
                    {
                        if (timeDiff - timeDiff / 60 * 60 < 10)
                        {
                            Console.WriteLine((timeDiff / 60) + ":0" + (timeDiff - (timeDiff / 60) * 60) + " minutes before the start");
                        }
                        else
                        {
                            Console.WriteLine((timeDiff / 60) + ":" + (timeDiff - (timeDiff / 60) * 60) + " minutes before the start");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{timeDiff} minutes before the start");
                    }
                }
            }
            else
            {
                Console.WriteLine("Early");
                if (timeDiff / 60 > 0)
                {
                    if (timeDiff - timeDiff / 60 * 60 < 10)
                    {
                        Console.WriteLine((timeDiff / 60) + ":0" + (timeDiff - (timeDiff / 60) * 60) + " hours before the start");
                    }
                    else
                    {
                        Console.WriteLine((timeDiff / 60)+":" +(timeDiff - (timeDiff / 60) * 60 )+" hours before the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{timeDiff} minutes before the start");
                }
            }
        }
    }
}
