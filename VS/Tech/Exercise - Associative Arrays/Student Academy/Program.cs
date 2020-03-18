using System;
using System.Linq;
using System.Collections.Generic;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbderOfStudents = int.Parse(Console.ReadLine());
            var studentAndGrades = new Dictionary<string, double>();
            var studentAndNumberOfGrades = new Dictionary<string, int>();

            for (int i = 0; i < numbderOfStudents; i++)
            {
                string nameOfStudent = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentAndGrades.ContainsKey(nameOfStudent))
                {
                    studentAndGrades.Add(nameOfStudent, grade);
                    studentAndNumberOfGrades.Add(nameOfStudent, 1);
                }
                else
                {
                    studentAndNumberOfGrades[nameOfStudent]++;
                    studentAndGrades[nameOfStudent] += grade;
                }
            }

            foreach (var kvp in studentAndGrades.OrderByDescending(x=>x.Value/studentAndNumberOfGrades[x.Key]))
            {
                if (kvp.Value / studentAndNumberOfGrades[kvp.Key] >= 4.5)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value / studentAndNumberOfGrades[kvp.Key]:f2}");
                }
            }
        }
    }
}
