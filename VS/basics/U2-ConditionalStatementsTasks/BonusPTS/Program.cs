using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPTS
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double finalNum = 0;

            if (num <= 100) finalNum += 5;
            else
            {
                if (num <= 1000) finalNum = num * 0.2;
                else finalNum = num * 0.1;
            }

            if (num % 2 == 0) finalNum++;
            if (num % 10 == 5) finalNum += 2;

            Console.WriteLine(finalNum);
            Console.WriteLine(num + finalNum);
        }
    }
}
