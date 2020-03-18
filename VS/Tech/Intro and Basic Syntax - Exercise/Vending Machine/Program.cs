using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            bool startFlag = false;
            double cash = 0;
            string input = string.Empty;
            while (true)
            {
                if (startFlag == true)
                {
                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "Nuts":
                            if (cash >= 2)
                            {
                                cash -= 2;
                                Console.WriteLine("Purchased nuts");
                            }
                            else Console.WriteLine("Sorry, not enough money");
                            break;
                        case "Water":
                            if (cash >= 0.7)
                            {
                                cash -= 0.7;
                                Console.WriteLine("Purchased water");
                            }
                            else Console.WriteLine("Sorry, not enough money");
                            break;
                        case "Crisps":
                            if (cash >= 1.5)
                            {
                                cash -= 1.5;
                                Console.WriteLine("Purchased crisps");
                            }
                            else Console.WriteLine("Sorry, not enough money");
                            break;
                        case "Soda":
                            if (cash >= 0.8)
                            {
                                cash -= 0.8;
                                Console.WriteLine("Purchased soda");
                            }
                            else Console.WriteLine("Sorry, not enough money");
                            break;
                        case "Coke":
                            if (cash >= 1)
                            {
                                cash -= 1;
                                Console.WriteLine("Purchased coke");
                            }
                            else Console.WriteLine("Sorry, not enough money");
                            break;
                        case "End":
                            Console.WriteLine($"Change: {cash:f2}");
                            return;
                            break;
                        default:
                            Console.WriteLine("Invalid product");
                            break;
                    }
                }
                else
                {
                    input = Console.ReadLine();
                    if (input == "Start") startFlag = true;
                    else
                    {
                        if (input == "0.1" || input == "0.2" || input == "0.5" || input == "1" || input == "2")
                            cash += double.Parse(input);
                        else Console.WriteLine($"Cannot accept {input}");
                    }
                }
            }
        }
    }
}
