using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maiden_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfParty = double.Parse(Console.ReadLine());
            int loveLetters = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int keyrings = int.Parse(Console.ReadLine());
            int drawings = int.Parse(Console.ReadLine());
            int surprises = int.Parse(Console.ReadLine());
            double cash = 0;
            cash = loveLetters * 0.6 + roses * 7.2 + keyrings * 3.6 + drawings * 18.2 + surprises * 22;
            cash = (loveLetters + roses + keyrings + drawings + surprises >= 25) ? cash * 0.65 : cash;
            cash *= 0.9;
            if (cash - priceOfParty >= 0) Console.WriteLine($"Yes! {cash - priceOfParty:f2} lv left.");
            else Console.WriteLine($"Not enough money! {priceOfParty - cash:f2} lv needed.");
        }
    }
}
