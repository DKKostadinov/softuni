using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            int num = 0;
            int digit = 0;

            for (int i = firstNumber; i < secondNumber; i++)
            {
                num = i;
                for (int j = 0; j < 7; j++)
                {
                    digit = num % 10;
                    if (j % 2 == 0) evenSum += digit;
                    else oddSum += digit;
                    num = num / 10;
                }
                if (oddSum == evenSum) Console.Write(i + " ");
            }
        }
    }
}
