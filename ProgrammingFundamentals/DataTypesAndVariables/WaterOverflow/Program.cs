using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 0;
            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters + capacity > 255) Console.WriteLine("Insufficient capacity!");
                else
                {
                    capacity += liters;
                }
            }
            Console.WriteLine(capacity);
        }
    }
}
