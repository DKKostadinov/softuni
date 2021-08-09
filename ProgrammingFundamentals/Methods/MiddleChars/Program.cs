using System;

namespace MiddleChars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MiddleChar(Console.ReadLine()));
        }
        static string MiddleChar(string text)
        {
            string output = "";
            if(text.Length % 2 == 0)
            {
                output += text[text.Length / 2 - 1];
                output += text[text.Length / 2];
            }
            else
            {
                output += text[text.Length / 2];
            }
            return output;
        }
    }
}
