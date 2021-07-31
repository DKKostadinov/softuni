using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                int evenSum = 0;
                int oddSum = 0;
                int num = i;
                for (int j = 0; j < 6; j++)
                {
                    if (j%2==0)
                    {
                        oddSum += num % 10;
                    }
                    else
                    {
                        evenSum += num % 10;
                    }
                    num /= 10;
                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
