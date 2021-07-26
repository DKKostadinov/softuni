using System;

namespace TimePlus15m
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += hours * 60 + 15;
            hours = minutes / 60;
            minutes -= 60 * hours;
            hours = (hours >= 24) ? hours - 24 : hours;

            if (hours < 1)
            {
                if (minutes < 10)
                {
                    Console.WriteLine("0:0" + minutes);
                }
                else
                {
                    Console.WriteLine("0:" + minutes);
                }
            }
            else
            {
                if (minutes < 10)
                {
                    Console.WriteLine(hours + ":0" + minutes);
                }
                else
                {
                    Console.WriteLine(hours + ":" + minutes);
                }
            }
        }
    }
}
