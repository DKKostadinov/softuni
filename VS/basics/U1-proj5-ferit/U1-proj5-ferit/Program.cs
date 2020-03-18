using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_proj5_ferit
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double moonshine = double.Parse(Console.ReadLine());
            double whiskey = double.Parse(Console.ReadLine());
            double price = (whiskey * whiskeyPrice) + (moonshine * (whiskeyPrice / 2)) +
                            (wine * (whiskeyPrice / 2 - (whiskeyPrice / 2) * 0.4)) + 
                                (beer * (whiskeyPrice / 2 - (whiskeyPrice / 2) * 0.8));
            Console.WriteLine($"{price:F2}");
        }
    }
}
