using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestKegName = "";
            double biggestKegCap = 0;
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * height;
                if (volume > biggestKegCap)
                {
                    biggestKegName = name;
                    biggestKegCap = volume;
                }
            }
            Console.WriteLine(biggestKegName); 
        }
    }

}
