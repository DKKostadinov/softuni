using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1110; i < 10000; i++)
            {
                int spec = i;
                int d = spec % 10;
                spec = (spec - spec % 10) / 10;
                int c = spec % 10;
                spec = (spec - spec % 10) / 10;
                int b = spec % 10;
                spec = (spec - spec % 10) / 10;
                int a = spec;

                if (a != 0 && b != 0 && c != 0 && d != 0)
                {
                    if (num % a == 0 && num % b == 0 && num % c == 0 && num % d == 0) Console.Write(i + " ");
                }
            }
        }
    }
}
