using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            int coinCount = 0;
            while (sum > 0)
            {
                if (sum - 2 >= 0)
                {
                    coinCount++;
                    sum = sum - 2;
                }
                else if (sum - 1 >= 0)
                {
                    coinCount++;
                    sum = sum - 1;
                }
                else if (sum - 0.50 >= 0)
                {
                    coinCount++;
                    sum = sum - 0.5;
                }
                else if (sum - 0.2 >= 0)
                {
                    coinCount++;
                    sum = sum - 0.2;
                }
                else if (sum - 0.1 >= 0)
                {
                    coinCount++;
                    sum = sum - 0.1;
                }
                else if (sum - 0.05 >= 0)
                {
                    coinCount++;
                    sum = sum - 0.05;
                }
                else if (sum - 0.02 >= 0)
                {
                    coinCount++;
                    sum = sum - 0.02;
                }
                else if (sum - 0.01 >= 0)
                {
                    coinCount++;
                    sum = sum - 0.01;
                }
                sum = Math.Round(sum, 2);
            }
            Console.WriteLine(coinCount);
            
        }
    }
}
