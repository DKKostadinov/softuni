using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfJury = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double singleAvg = 0;
            double allAvg = 0;
            int numberOfPresentations = 0;
            while (input.ToLower() != "finish")
            {
                numberOfPresentations++;
                for (int i = 0; i < numberOfJury; i++)
                {
                    singleAvg += double.Parse(Console.ReadLine());
                }
                singleAvg /= numberOfJury;
                allAvg += singleAvg;
                Console.WriteLine($"{input} - {singleAvg:f2}.");
                input = Console.ReadLine();
                singleAvg = 0;
            }
            allAvg /= numberOfPresentations;
            Console.WriteLine($"Student's final assessment is {allAvg:f2}.");

        }
    }
}
