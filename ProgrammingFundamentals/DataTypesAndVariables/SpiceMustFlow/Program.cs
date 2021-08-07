using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int storage = 0;
            int count = 0;
            while (yield >= 100)
            {
                count++;
                storage += yield;
                storage -= 26;
                if (storage < 0) storage = 0;
                yield -= 10;
            }
            storage -= 26;
            if (storage < 0) storage = 0;
            Console.WriteLine(count);
            Console.WriteLine(storage);
        }
    }
}
