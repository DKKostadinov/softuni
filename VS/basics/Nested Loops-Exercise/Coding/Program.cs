using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int len = (num.ToString()).Length;
            for (int i = 0; i < len; i++)
            {
                if (num % 10 == 0)
                {
                    Console.WriteLine("ZERO");
                    num /= 10;
                    continue;
                }
                for (int j = 0; j < num%10; j++)
                {
                    switch (num%10)
                    {
                        case 1:
                            Console.Write("\"");
                            break;
                        case 2:
                            Console.Write("#");
                            break;
                        case 3:
                            Console.Write("$");
                            break;
                        case 4:
                            Console.Write("%");
                            break;
                        case 5:
                            Console.Write("&");
                            break;
                        case 6:
                            Console.Write("'");
                            break;
                        case 7:
                            Console.Write("(");
                            break;
                        case 8:
                            Console.Write(")");
                            break;
                        case 9:
                            Console.Write("*");
                            break;
                        default:
                            break;
                    }
                }
                num /= 10;
                Console.WriteLine();
            }
        }
    }
}
