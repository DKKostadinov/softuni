using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfJudges = int.Parse(Console.ReadLine());
            double sumOfAllGrades = 0;
            int numberOfGrades = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Finish") break;
                double sumOfGrades = 0;
                for (int i = 0; i < numberOfJudges; i++)
                {
                    sumOfGrades += double.Parse(Console.ReadLine());
                    numberOfGrades++;
                }
                sumOfAllGrades += sumOfGrades;
                Console.WriteLine($"{input} - {sumOfGrades/numberOfJudges:0.00}.");
            }
            Console.WriteLine($"Student's final assessment is {sumOfAllGrades/numberOfGrades:0.00}.");
        }
    }
}
