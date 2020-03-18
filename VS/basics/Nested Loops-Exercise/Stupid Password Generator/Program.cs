using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int k = 1; k <= l; k++)
                    {
                        for (int o = 1; o <= l; o++)
                        {
                            for (int p = 1; p <= n; p++)
                            {
                                if (p > i && p > j)
                                {
                                    char a = (char)((int)'a' + k - 1);
                                    char b = (char)((int)'a' + o - 1);
                                    Console.Write($"{i}{j}{a}{b}{p} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
