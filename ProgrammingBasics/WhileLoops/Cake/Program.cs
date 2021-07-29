using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine());
            string input = "";
            while (size > 0)
            {
                input = Console.ReadLine();
                if (input == "STOP") break;
                size -= int.Parse(input);
            }
            if (input == "STOP")
            {
                Console.WriteLine($"{size} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(size)} pieces more.");
            }
        }
    }
}
