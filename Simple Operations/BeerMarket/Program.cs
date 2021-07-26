using System;

namespace BeerMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var whiskeyPrice = double.Parse(Console.ReadLine());
            var beer = double.Parse(Console.ReadLine());
            var wine = double.Parse(Console.ReadLine());
            var rakia = double.Parse(Console.ReadLine());
            var whiskey = double.Parse(Console.ReadLine());

            var priceTotal = whiskey * whiskeyPrice + rakia * whiskeyPrice / 2 
                + wine * whiskeyPrice / 2 * 0.6 + beer * whiskeyPrice / 2 * 0.2;

            Console.WriteLine(String.Format("{0:0.00}", priceTotal));
        }
    }
}
