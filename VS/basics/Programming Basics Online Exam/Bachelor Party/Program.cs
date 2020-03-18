using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfSinger = int.Parse(Console.ReadLine());
            double cash = 0;
            string input = string.Empty;
            int groupSize = 0;
            int allGuests = 0;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "The restaurant is full") break;
                else
                {
                    groupSize = int.Parse(input);
                    allGuests += groupSize;
                    cash = (groupSize < 5) ? cash + groupSize * 100 : cash + groupSize * 70;
                }
            }

            if (cash - priceOfSinger >= 0) Console.WriteLine($"You have {allGuests} guests and {cash - priceOfSinger} leva left.");
            else Console.WriteLine($"You have {allGuests} guests and {cash} leva income, but no singer.");
        }
    }
}
