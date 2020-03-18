using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDeposits = int.Parse(Console.ReadLine());
            double deposit = 0;
            double total = 0;

            for (int i = 0; i < numOfDeposits; i++)
            {
                deposit = double.Parse(Console.ReadLine());
                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                total += deposit;
                Console.WriteLine($"Increase: {deposit:f2}");
            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
