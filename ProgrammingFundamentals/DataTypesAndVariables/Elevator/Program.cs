using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int fullCourses = numberOfPeople / capacity;
            int partialCourse = numberOfPeople - fullCourses * capacity;
            if (capacity >= numberOfPeople) Console.WriteLine("All the persons fit inside in the elevator.\nOnly one course is needed.");
            else
            {
                Console.WriteLine($"{fullCourses} courses * {capacity} people");
                if (partialCourse > 0) Console.WriteLine($"+ 1 course * {partialCourse} persons");
            }
        }
    }
}
