using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_proj4_greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");

            /*
             *Console.WriteLine($"Hello, {name}");
             * $ - za placeholder
             * {neshto} - sus {} se slagat placeholderi kato neshto e ime na promenliva 
             */
        }
    }
}
