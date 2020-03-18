using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededCash = double.Parse(Console.ReadLine());
            double availablecash = double.Parse(Console.ReadLine());
            string typeOfDay = string.Empty;
            double cashChange = 0;
            int consecutiveSpendDays = 0;
            int numberOfDays = 0;


            while (true)
            {
                typeOfDay = Console.ReadLine();
                cashChange = double.Parse(Console.ReadLine());
                numberOfDays++;
                if (typeOfDay == "spend")
                {
                    consecutiveSpendDays++;
                    availablecash -= cashChange;
                    if (availablecash < 0) availablecash = 0;
                }
                if (typeOfDay == "save")
                {
                    consecutiveSpendDays = 0;
                    availablecash += cashChange;
                }
                if (consecutiveSpendDays == 5)
                {
                    Console.WriteLine($"You can't save the money.\n{numberOfDays}");
                    break;
                }
                if (availablecash >= neededCash)
                {
                    Console.WriteLine($"You saved the money for {numberOfDays} days.");
                    break;
                }

            }

        }
    }
}
