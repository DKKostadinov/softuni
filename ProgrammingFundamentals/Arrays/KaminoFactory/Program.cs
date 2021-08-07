using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bestSeqLength = 0;
            int bestSeqIndex = 0;
            int[] bestSeq = new int[n];
            int index = -1;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Clone them!") break;
                int[] arr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int seqLength = 1;
                int seqIndex = 0;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] != arr[i - 1] && arr[i] == 1)
                    {
                        seqIndex = i;
                        seqLength = 1;
                    }
                    if (arr[i] == arr[i-1] && arr[i] == 1)
                    {
                        seqLength++;
                    }
                    if(seqLength > bestSeqLength)
                    {
                        bestSeqLength = seqLength;
                        bestSeqIndex = seqIndex;
                        bestSeq = arr;
                    }
                }
                index++;
            }
            Console.WriteLine($"Best DNA sample {index} with sum: {bestSeqLength}.");
            foreach (var item in bestSeq)
            {
                Console.Write(item+" ");
            }
        }
    }
}
