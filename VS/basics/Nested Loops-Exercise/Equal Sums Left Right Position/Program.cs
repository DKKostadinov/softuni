using System;
using System.Diagnostics;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int rightSum = 0;
            int leftSum = 0;
            int midDigit = 0;

            int currentNum = 0;

            for (int i = firstNum; i <= secondNum; i++)
            {
                currentNum = i;

                for (int j = 1; j <= 5; j++)
                {
                    int lastDigit = currentNum % 10;
                    currentNum = (currentNum - lastDigit) / 10;

                    if (j == 1 || j == 2)
                    {
                        rightSum += lastDigit;
                    }
                    else if (j == 3)
                    {
                        midDigit = lastDigit;
                    }
                    else
                    {
                        leftSum += lastDigit;
                    }
                }
                if (leftSum == rightSum)
                {
                    Console.Write($"{i} ");
                }
                else
                {
                    if (leftSum > rightSum) rightSum += midDigit;
                    else leftSum += midDigit;
                    if (leftSum == rightSum)
                    Console.Write($"{i} ");
                }
                
                rightSum = 0;
                leftSum = 0;
            }
        }
    }
}
