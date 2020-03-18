using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int flag = 0;
            int maxDiff = -1000000000;
            int[] value = new int[n];

            for (int i = 0; i < n; i++)
            {
                value[i] = int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine());
                if (i > 0)
                {
                    if(value[i] != value[0])
                    {
                        flag = 1;
                        maxDiff = (Math.Abs(value[i] - value[i - 1]) > maxDiff) ? (Math.Abs(value[i] - value[i - 1])) : maxDiff;
                    }
                }
            }
            if (flag == 0) Console.WriteLine($"Yes, value={value[0]}");
            else Console.WriteLine($"No, maxdiff={maxDiff}");
            
        }
    }
}
