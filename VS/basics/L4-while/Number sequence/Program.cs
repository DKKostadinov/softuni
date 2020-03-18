using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = int.Parse(input);
            int max = num;
            int min = num;
            while (input != "END")
            {
                num = int.Parse(input);
                if (num > max) max = num;
                if (num < min) min = num;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Max number: {max}\nMin number: {min}");
        }
    }
}
