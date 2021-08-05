using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            Console.WriteLine(inputArray);
        }
    }
}
