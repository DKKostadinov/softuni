using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeLeft = int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine());
            string input = string.Empty;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "STOP")
                {
                    Console.WriteLine($"{cakeLeft} pieces are left.");
                    break;
                }
                cakeLeft -= int.Parse(input);
                if(cakeLeft < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeLeft)} pieces more.");
                    break;
                }
            }
        }
    }
}
