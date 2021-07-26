using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var bakers = int.Parse(Console.ReadLine());
            var cakes = int.Parse(Console.ReadLine());
            var waffles = int.Parse(Console.ReadLine());
            var pancakes = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Format("{0:0.00}", days * bakers * (waffles * 5.8 + pancakes * 3.2 + cakes * 45) * 7 / 8));
        }
    }
}
