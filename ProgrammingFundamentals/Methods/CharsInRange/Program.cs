using System;

namespace CharsInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCharsInRange(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()));
        }
        static void PrintCharsInRange(char start, char end)
        {
            for (int i = start + 1; i < end; i++)
            {
                Console.Write((char)i + " ");
            }
            for (int i = end + 1; i < start; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
