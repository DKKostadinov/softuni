using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_proj2_kvadrat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input side of square = ");
            int a = int.Parse(Console.ReadLine());
            int area = a * a;
            Console.WriteLine(area);
        }
    }
}
