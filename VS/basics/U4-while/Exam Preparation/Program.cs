using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxBadGrades = int.Parse(Console.ReadLine());
            int badGrades = 0;
            string nameOfExercise = string.Empty;
            double grade = 0;
            string lastExercise = string.Empty;
            double allGrades = 0;
            int numberOfExercises = 0;

            while (true)
            {
                lastExercise = nameOfExercise;
                nameOfExercise = Console.ReadLine();
                if (nameOfExercise == "Enough")
                {
                    Console.WriteLine($"Average score: {allGrades/numberOfExercises:f2}\nNumber of problems: {numberOfExercises}\nLast problem: {lastExercise}");
                    break;
                }
                grade = double.Parse(Console.ReadLine());
                allGrades += grade;
                numberOfExercises++;
                if (grade <= 4.00) badGrades++;
                if(badGrades == maxBadGrades)
                {
                    Console.WriteLine($"You need a break, {maxBadGrades} poor grades.");
                    break;
                }

            }
        }
    }
}
