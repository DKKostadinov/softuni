using System;

namespace WorldSwimmingLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordTime = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double slowedDown = Math.Floor(distance / 15) * 12.5;
            double neededTime = distance * timePerMeter + slowedDown;

            if (neededTime < recordTime)
            {
                Console.WriteLine(" Yes, he succeeded! The new world record is " + String.Format("{0:0.00}",neededTime) + " seconds.");
            }
            else
            {
                Console.WriteLine("No, he failed! He was " + String.Format("{0:0.00}",neededTime - recordTime) + " seconds slower.");
            }
        }
    }
}
