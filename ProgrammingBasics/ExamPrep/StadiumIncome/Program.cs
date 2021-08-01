using System;

namespace StadiumIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            int sectors = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            double totalIncome = capacity * ticketPrice;
            double incomePerSector = totalIncome / sectors;
            double charity = (totalIncome - 0.75 * incomePerSector) / 8;
            Console.WriteLine($"Total income - {totalIncome:0.00} BGN\n");
            Console.WriteLine($"Money for charity - {charity:0.00} BGN");
        }
    }
}
