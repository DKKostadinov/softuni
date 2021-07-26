using System;

namespace Scholarships
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double GPA = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double socialSch = 0;
            double gradeSch = 0;

            if (income < minSalary && GPA > 4.5)
            {
                socialSch = 0.35 * minSalary;
            }
            if (GPA >= 5.5)
            {
                gradeSch = GPA * 25;
            }

            if (socialSch > 0 || gradeSch > 0)
            {
                if (gradeSch >= socialSch)
                {
                    Console.WriteLine("You get a scholarship for excellent results " + Math.Floor(gradeSch) + " BGN");
                }
                else
                {
                    Console.WriteLine("You get a Social scholarship "+Math.Floor(socialSch)+" BGN");
                }
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
