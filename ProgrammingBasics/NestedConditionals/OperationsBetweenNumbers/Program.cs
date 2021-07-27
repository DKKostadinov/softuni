using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            double result = 0;
            string evenOrOdd = "0";
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    evenOrOdd = (result % 2 == 0) ? "even" : "odd";
                    break;
                case "-":
                    result = num1 - num2;
                    evenOrOdd = (result % 2 == 0) ? "even" : "odd";
                    break;
                case "*":
                    result = num1 * num2;
                    evenOrOdd = (result % 2 == 0) ? "even" : "odd";
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                        return;
                    }
                    result = (double)num1 / (double)num2;
                    break;
                case "%":
                    if(num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                        return;
                    }
                    result = (double)num1 % (double)num2;
                    break;
                default:
                    break;
            }

            Console.Write($"{num1} {op} {num2} = {Math.Round(result,2)}");
            if (evenOrOdd != "0") Console.Write($" - {evenOrOdd}");
        }
    }
}
