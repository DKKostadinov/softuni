using System;
using System.Linq;
using System.Collections.Generic;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courseCollection = new Dictionary<string, List<string>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] splitInput = input.Split(" : ");
                string courseName = splitInput[0];
                string studentName = splitInput[1];
                if (!courseCollection.ContainsKey(courseName))
                    courseCollection.Add(courseName, new List<string>());
                courseCollection[courseName].Add(studentName);
            }

            foreach (var kvp in courseCollection.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{kvp.Key}: {courseCollection[kvp.Key].Count}");
                courseCollection[kvp.Key].Sort();
                foreach (var item in courseCollection[kvp.Key])
                {
                    Console.WriteLine($"-- {item}");
                }
            }

        }
    }
}
