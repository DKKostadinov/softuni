using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_dispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int buttonPressCounter = 0;
            while (true)
            {
                buttonPressCounter++;
                string input = Console.ReadLine();
                switch (input)
                {
                    case "Easy":
                        volume -= 50;
                        break;
                    case "Medium":
                        volume -= 100;
                        break;
                    case "Hard":
                        volume -= 200;
                        break;
                    default:
                        break;
                }
                if(volume == 0)
                {
                    Console.WriteLine($"The dispenser has been tapped {buttonPressCounter} times.");
                    break;
                }
                if(volume < 0)
                {
                    Console.WriteLine($"{Math.Abs(volume)}ml has been spilled.");
                    break;
                }
            }
        }
    }
}
