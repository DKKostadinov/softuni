using System;

namespace Strong_number
{
    class Program
    {

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int originalNumber = number;
            int sumOfFactorials = 0;
            int lengthOfnumber = (number.ToString()).Length;
            for (int i = 0; i < lengthOfnumber; i++)
            {
                sumOfFactorials += Factorial(number % 10);
                number /= 10;
            }
            if (originalNumber == sumOfFactorials) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }

        static int Factorial(int number)
        {
            if (number == 1) return 1;
            else return number * Factorial(number - 1);
        }
    }
}
