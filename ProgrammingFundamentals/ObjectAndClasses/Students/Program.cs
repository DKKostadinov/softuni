using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                students.Add(new Student(input[0], input[1], double.Parse(input[2])));
            }
            students = students.OrderByDescending(x => x.Grade).ToList();
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public double Grade { get; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:0.00}";
        }
    }
}
