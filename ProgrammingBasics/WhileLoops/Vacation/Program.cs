using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededCash = double.Parse(Console.ReadLine());
            double capital = double.Parse(Console.ReadLine());
            int consecutiveDays = 0;
            int totalDays = 0;
            while (consecutiveDays < 5 && capital < neededCash)
            {
                totalDays++;
                string input = Console.ReadLine();
                double transactionMoney = double.Parse(Console.ReadLine());
                if (input == "save")
                {
                    capital += transactionMoney;
                }
                else
                {
                    capital -= transactionMoney;
                    capital = (capital < 0) ? 0 : capital;
                    consecutiveDays++;
                }
            }
            if (capital >= neededCash)
            {
                Console.WriteLine($"You saved the money for {totalDays} days.");
            }
            else
            {
                Console.WriteLine($"You can't save the money.\n{totalDays}");
            }
        }
    }
}
