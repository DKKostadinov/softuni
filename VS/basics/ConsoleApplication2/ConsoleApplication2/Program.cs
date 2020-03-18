using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int toy = int.Parse(Console.ReadLine());
            double savings = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0) savings += (i * 5) - 1;
                else savings += toy;
            }

            if (savings - price >= 0) Console.WriteLine($"Yes! {savings - price:f2}");
            else Console.WriteLine($"No! {Math.Abs(savings-price):f2}");
        }
    }
}
