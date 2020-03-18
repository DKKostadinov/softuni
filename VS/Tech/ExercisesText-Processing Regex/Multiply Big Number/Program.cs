using System;
using System.Text;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //7 * 15841651 = 110891557
            string bigNumber = Console.ReadLine().TrimStart('0');
            int smallNumber = int.Parse(Console.ReadLine());
            int numberInMind = 0;
            StringBuilder output = new StringBuilder();
            if (bigNumber == "0" || smallNumber == 0 || bigNumber == "")
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(bigNumber[i].ToString());
                int currentResult = currentDigit * smallNumber + numberInMind;
                if (currentResult <= 9)
                {
                    numberInMind = 0; 
                    output.Append(currentResult);
                }
                else
                {
                    output.Append(currentResult % 10);
                    numberInMind = currentResult / 10;
                }   
            }
            if (numberInMind != 0)
                output.Append(numberInMind);

            char[] reversedOutput = output.ToString().ToCharArray();
            Array.Reverse(reversedOutput);
            foreach (var item in reversedOutput)
            {
                Console.Write(item);
            }
        }
    }
}
