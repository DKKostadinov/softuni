using System;
using System.Text;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            StringBuilder stringOutput = new StringBuilder();
            foreach (var symbol in inputString)
            {
                stringOutput.Append((char)(symbol + 3));
            }
            Console.WriteLine(stringOutput.ToString());
        }
    }
}
