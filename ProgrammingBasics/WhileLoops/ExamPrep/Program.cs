using System;

namespace ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximumBadGrades = int.Parse(Console.ReadLine());
            string input = "";
            int badGradesCount = 0;
            int gradesCount = 0;
            double combinedGrade = 0;
            string lastProblem = "";
            while (badGradesCount<maximumBadGrades)
            {
                input = Console.ReadLine();
                if (input == "Enough") break;
                lastProblem = input;
                double grade = double.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    badGradesCount++;
                }
                combinedGrade += grade;
                gradesCount++;
            }

            if (input == "Enough")
            {
                Console.WriteLine($"Average score: {combinedGrade/gradesCount:f2}\nNumber of problems: {gradesCount}\nLast problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {maximumBadGrades} poor grades.");
            }
        }
    }
}
