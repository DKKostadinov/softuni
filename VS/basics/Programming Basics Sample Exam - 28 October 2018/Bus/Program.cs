using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int passangerNumber = int.Parse(Console.ReadLine());
            int stopsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < stopsNumber; i++)
            {
                passangerNumber -= int.Parse(Console.ReadLine());
                passangerNumber += int.Parse(Console.ReadLine());
            }
            passangerNumber = (stopsNumber % 2 != 0) ? passangerNumber + 2 : passangerNumber;
            Console.WriteLine("The final number of passengers is : " + passangerNumber);
        }
    }
}
