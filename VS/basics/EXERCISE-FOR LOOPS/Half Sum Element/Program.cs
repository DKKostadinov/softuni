using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = -10000000;
            int sum = 0;
            int num = 0;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
                max = (num > max) ? num : max;
            }

             if (2 * max == sum) Console.WriteLine($"Yes\nSum = {max}");
             else Console.WriteLine($"No\nDiff = {Math.Abs(2 * max-sum)}");
        }
    }
}
