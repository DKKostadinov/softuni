using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commision = -1;
            switch (city)
            {
                case "Sofia":
                    if (sales >= 0 && sales <= 500)
                        commision = sales * 0.05;
                    else if (sales > 500 && sales <= 1000)
                        commision = sales * 0.07;
                    else if (sales > 1000 && sales < 10000)
                        commision = sales * 0.08;
                    else if (sales > 10000)
                        commision = sales * 0.12;
                    if(commision >= 0)
                        Console.WriteLine($"{commision:f2}");
                    else Console.WriteLine("error");
                    break;
                case "Varna":
                    if (sales >= 0 && sales <= 500)
                        commision = sales * 0.045;
                    else if (sales > 500 && sales <= 1000)
                        commision = sales * 0.075;
                    else if (sales > 1000 && sales < 10000)
                        commision = sales * 0.1;
                    else if (sales > 10000)
                        commision = sales * 0.13;
                    if (commision >= 0)
                        Console.WriteLine($"{commision:f2}");
                    else Console.WriteLine("error");
                    break;
                case "Plovdiv":
                    if (sales >= 0 && sales <= 500)
                        commision = sales * 0.055;
                    else if (sales > 500 && sales <= 1000)
                        commision = sales * 0.08;
                    else if (sales > 1000 && sales < 10000)
                        commision = sales * 0.12;
                    else if (sales > 10000)
                        commision = sales * 0.145;
                    if (commision >= 0)
                        Console.WriteLine($"{commision:f2}");
                    else Console.WriteLine("error");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

        }
    }
}
