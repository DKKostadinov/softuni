using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentClass = 1;
            double sum = 0;
            double grade = 0;

            while (currentClass <= 12)
            {
                grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    currentClass++;
                    sum += grade;
                }
            }
            Console.WriteLine($"{name} graduated. Average grade: {(sum/12):f2}");
        }
    }
}
