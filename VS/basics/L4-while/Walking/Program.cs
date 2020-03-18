using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int steps = 0;
            if(input != "Going home") steps = int.Parse(input);
            int allSteps = steps;

            while (allSteps < 10000)
            {
                input = Console.ReadLine();
                if (input == "Going home")
                {
                    steps = int.Parse(Console.ReadLine());
                    allSteps += steps;
                    break;
                }
                if (input != "Going home") steps = int.Parse(input);
                allSteps += steps;
            }

            if (allSteps < 10000) Console.WriteLine($"{(10000 - allSteps)} more steps to reach goal.");
            else Console.WriteLine("Goal reached! Good job!");
        } 
    }
}
