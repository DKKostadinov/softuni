using System;

namespace EqualSumLeftRightPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                int num = i;
                int middle = 0;
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (j == 2) middle = num % 10;
                    if (j == 0 || j == 1) leftSum += num % 10;
                    if (j == 3 || j == 4) rightSum += num % 10;
                    num /= 10;
                }
                if (leftSum == rightSum)
                {
                    Console.Write(i + " ");
                }
                else if (leftSum + middle == rightSum || rightSum + middle == leftSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
