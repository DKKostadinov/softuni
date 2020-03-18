using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            string evenOrOdd = "";
            int flag = -1;
            double result = -1;
            

            switch (operation)
            {
                case "+":
                    evenOrOdd = ((num1 + num2) % 2 == 0) ? " - even" : " - odd";
                    flag = 1;
                    result = num1 + num2;
                    break;
                case "-":
                    evenOrOdd = ((num1 - num2) % 2 == 0) ? " - even" : " - odd";
                    flag = 1;
                    result = num1 - num2;
                    break;
                case "*":
                    evenOrOdd = ((num1 * num2) % 2 == 0) ? " - even" : " - odd";
                    flag = 1;
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                        return;
                    }
                    flag = 2;
                    result = num1 / (double)num2;
                    break;
                case "%":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                        return;
                    }
                    flag = 1;
                    result = num1 % (double)num2;
                    break;
                default:
                    break;
            }
            if(flag == 1) Console.WriteLine($"{num1} {operation} {num2} = {result:f0}{evenOrOdd}");
            if(flag == 2) Console.WriteLine($"{num1} {operation} {num2} = {result:f2}{evenOrOdd}");
        }
    }
}
