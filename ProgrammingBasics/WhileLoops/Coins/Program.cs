using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = (int)(100 * double.Parse(Console.ReadLine()));
            int output = 0;

            while(input != 0)
            {
                if (input >= 200)
                {
                    input -= 200;
                }
                else if (input >= 100)
                {
                    input -= 100;
                }
                else if (input >= 50)
                {
                    input -= 50;
                }
                else if (input >= 20)
                {
                    input -= 20;
                }
                else if (input >= 10)
                {
                    input -= 10;
                }
                else if (input >= 5)
                {
                    input -= 5;
                }
                else if (input >= 2)
                {
                    input -= 2;
                }
                else if (input >= 1)
                {
                    input -= 1;
                }
                output++;
            }
            Console.WriteLine(output);
        }
    }
}
