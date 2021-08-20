using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (grades.ContainsKey(name)) grades[name].Add(grade);
                else grades.Add(name, new List<double>() { grade });
            }
            Dictionary<string, double> averages = new Dictionary<string, double>();
            foreach (var student in grades)
            {
                double avg = student.Value.Average();
                if (avg >= 4.5) averages.Add(student.Key, avg);
            }
            averages = averages.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var avg in averages)
            {
                Console.WriteLine($"{avg.Key} -> {avg.Value:0.00}");
            }
        }
    }
}
