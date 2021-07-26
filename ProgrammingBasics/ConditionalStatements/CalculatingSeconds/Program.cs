using System;

namespace CalculatingSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine());
            int minutes = (int)Math.Floor(seconds/60.0);
            seconds -= minutes * 60;

            if (minutes < 1)
            {
                if (seconds < 10)
                {
                    Console.Write("0:0" + seconds);
                }
                else
                {
                    Console.WriteLine("0:" + seconds);
                }
            }
            else
            {
                if (seconds < 10)
                {
                    Console.Write(minutes + ":0" + seconds);
                }
                else
                {
                    Console.WriteLine(minutes + ":" + seconds);
                }
            }
        }
    }
}
