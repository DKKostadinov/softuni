using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine());
            string input = string.Empty;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "Done")
                {
                    Console.WriteLine($"{volume} Cubic meters left.");
                    break;
                }
                volume -= int.Parse(input);
                if(volume < 0)
                {
                    Console.WriteLine($"No more free space! You need {(Math.Abs(volume))} Cubic meters more.");
                    break;
                }
                
            }
        }
    }
}
