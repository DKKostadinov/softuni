using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int ogN = N;
            int count = 0;
            while (N >= M)
            {
                count++;
                N -= M;
                if (N == ogN * 0.5) N /= Y;
            }
            Console.WriteLine(N);
            Console.WriteLine(count);
        }
    }
}
