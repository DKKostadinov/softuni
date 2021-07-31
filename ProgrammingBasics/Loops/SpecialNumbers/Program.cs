using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1111; i <= 9999; i++)
            {
                bool isSpecial = true;
                int temp = i;
                int[] digits = new int[4];
                for (int j = 0; j < 4; j++)
                {
                    digits[j] = temp % 10;
                    temp /= 10;
                }
                foreach (var digit in digits)
                {
                    if (digit == 0)
                    {
                        isSpecial = false;
                        continue;
                    }
                    if (number % digit != 0) isSpecial = false;
                }
                if (isSpecial) Console.Write(i + " ");
            }
        }
    }
}
