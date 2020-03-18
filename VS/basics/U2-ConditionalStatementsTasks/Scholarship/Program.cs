using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double gradeAvg = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            if (gradeAvg > 5.5 && (0.35 * minSalary <= gradeAvg * 25)) Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(gradeAvg * 25)} BGN");
            else if (gradeAvg > 4.5 && income < minSalary) Console.WriteLine($"You get a Social scholarship {Math.Floor(0.35 * minSalary)} BGN");
            else Console.WriteLine("You cannot get a scholarship!");
        }
    }
}