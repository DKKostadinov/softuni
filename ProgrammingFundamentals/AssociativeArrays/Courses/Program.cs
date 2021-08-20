using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") break;
                string[] inputArr = input.Split(" : ");
                string course = inputArr[0];
                string student = inputArr[1];
                if (courses.ContainsKey(course)) courses[course].Add(student);
                else courses.Add(course, new List<string>() { student });
            }
            courses = courses.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value);
            foreach (var course in courses)
            {
                courses[course.Key].Sort();
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
