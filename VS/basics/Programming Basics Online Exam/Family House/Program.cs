using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_House
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double allElectricity = 0;
            double allMisc = 0;
            for (int i = 0; i < months; i++)
            {
                double currentElectricity = double.Parse(Console.ReadLine());
                allElectricity += currentElectricity;
                allMisc += (currentElectricity + 35) * 1.2;
            }
            Console.WriteLine($"Electricity: {allElectricity:f2} lv");
            Console.WriteLine($"Water: {months * 20:f2} lv");
            Console.WriteLine($"Internet: {months * 15:f2} lv");
            Console.WriteLine($"Other: {allMisc:f2} lv");
            Console.WriteLine($"Average: {(allMisc+allElectricity)/months + 35:f2} lv");
        }
    }
}
