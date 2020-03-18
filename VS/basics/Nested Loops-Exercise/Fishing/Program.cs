using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int quota = int.Parse(Console.ReadLine());
            double cash = 0;
            double tempCash = 0;
            int i;
            for (i = 1; i <= quota; i++)
            {
                string fish = Console.ReadLine();
                if (fish == "Stop") break;
                double weight = double.Parse(Console.ReadLine());
                for (int j = 0; j < fish.Length; j++)
                {
                    tempCash += fish[j] / weight;
                }
                if (i % 3 == 0) cash += tempCash;
                else cash -= tempCash;
                tempCash = 0;
            }
            if (i == quota + 1) Console.WriteLine("Lyubo fulfilled the quota!");
            if (cash > 0) Console.WriteLine($"Lyubo's profit from {i - 1} fishes is {cash:f2} leva.");
            else Console.WriteLine($"Lyubo lost {Math.Abs(cash):f2} leva today.");
        }
    }
}
