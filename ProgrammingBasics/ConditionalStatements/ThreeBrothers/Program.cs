using System;

namespace ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double timeA = double.Parse(Console.ReadLine());
            double timeB = double.Parse(Console.ReadLine());
            double timeC = double.Parse(Console.ReadLine());
            double timeD = double.Parse(Console.ReadLine());

            double neededTime = 1.15 * (1 / (1 / timeA + 1 / timeB + 1 / timeC));

            Console.WriteLine("Cleaning time: " + Math.Round(neededTime, 2));
            if (neededTime <= timeD)
            {
                Console.WriteLine("Yes, there is a surprise - time left-> " + Math.Floor(timeD - neededTime) + " hours.");
            }
            else
            {
                Console.WriteLine("No, there isn't a surprise - shortage of time -> "+ Math.Ceiling(neededTime - timeD) + " hours.");
            }
        }
    }
}
