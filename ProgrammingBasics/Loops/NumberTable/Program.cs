using System;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int current = 1;
            for (int i = 1; i <= num; i++)
            {
                current = i;
                for (int j = i; j < num + i; j++)
                {
                    Console.Write($"{current} ");
                    if (current >= num)
                    {
                        current--;
                    }
                    else
                    {
                        current++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
