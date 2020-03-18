using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Maniac
{
    class Program
    {
        static void Main(string[] args)
        {
            int cash = int.Parse(Console.ReadLine());
            int fullCash = cash;
            int clothes = 0;
            int inside = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "enter") inside = 1;
                while (inside == 1)
                {
                    input = Console.ReadLine();
                    if (input == "leave")
                    {
                        inside = 0;
                        break;
                    }
                    if (cash - int.Parse(input) < 0) Console.WriteLine("Not enough money.");
                    else if (cash - int.Parse(input) == 0)
                    {
                        cash -= int.Parse(input);
                        clothes++;
                        inside = 0;
                        break;
                    }
                    else
                    {
                        cash -= int.Parse(input);
                        clothes++;
                    }
                }
                if (input == "enough" || cash == 0) break;
            }
            Console.WriteLine($"For {clothes} clothes I spent {fullCash - cash} lv and have {cash} lv left.");
        }
    }
}
