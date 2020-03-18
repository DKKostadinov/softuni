using System;
using System.Linq;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            string[] splitInput1 = input1.Split(" ").ToArray();
            string[] splitInput2 = input2.Split(" ").ToArray();

            foreach (var item1 in splitInput1)
            {
                foreach (var item2 in splitInput2)
                {
                    if (item1 == item2) Console.Write(item1 + " ");
                }
            }
        }
    }
}
