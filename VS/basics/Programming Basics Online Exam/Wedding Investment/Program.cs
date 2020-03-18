using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding_Investment
{
    class Program
    {
        static void Main(string[] args)
        {
            string length = Console.ReadLine();
            string size = Console.ReadLine();
            string dessert = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());
            double cash = 0;

            if (length == "one")
            {
                switch (size)
                {
                    case "Small":
                        cash = 9.98;
                        break;
                    case "Middle":
                        cash = 18.99;
                        break;
                    case "Large":
                        cash = 25.98;
                        break;
                    case "ExtraLarge":
                        cash = 35.99;
                        break;
                    default:
                        break;
                }
            }
            else if (length == "two")
            {
                switch (size)
                {
                    case "Small":
                        cash = 8.58;
                        break;
                    case "Middle":
                        cash = 17.09;
                        break;
                    case "Large":
                        cash = 23.59;
                        break;
                    case "ExtraLarge":
                        cash = 31.79;
                        break;
                    default:
                        break;
                }
                    
            }
            if (dessert == "yes")
            {
                if (cash <= 10) cash += 5.5;
                else if (cash <= 30) cash += 4.35;
                else cash += 3.85;
            }
            if (length == "two") cash *= 0.9625;
            cash *= months;
            Console.WriteLine($"{cash:f2} lv."); 

        }
    }
}
