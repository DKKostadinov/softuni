using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfSeq = int.Parse(Console.ReadLine());
            int counter = 0;
            int bestPosition = 0;
            string input = string.Empty;
            string best = string.Empty;
            int[] bestParameters = ParametersOfSeq(int.Parse("0000"), lengthOfSeq)
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            while (true)
            {
                input = Console.ReadLine();
                if (input == "Clone them!") break;
                counter++;
                input = Regex.Replace(input, @"!", "");

                int[] inputParameters = ParametersOfSeq(int.Parse(input), lengthOfSeq)
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                if(IsFirstSeqBest(inputParameters, bestParameters) == true)
                {
                    best = input;
                    bestParameters = ParametersOfSeq(int.Parse(best), lengthOfSeq)
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                    bestPosition = counter;
                }

            }

            Console.WriteLine($"Best DNA sample {bestPosition} with sum: {bestParameters[2]}.");
            foreach (var item in best)
            {
                Console.Write(item + " ");
            }

        }

        //length index sum
        static string ParametersOfSeq(int sequence, int lengthOfSeq)
        {
            int sumOfElements = 0;
            int currentSubseq = 0;
            int indexOfSubseq = 0;
            int lengthOfSubseq = 0;

            for (int i = 0; i < lengthOfSeq; i++)
            {
                int digit = sequence % 10;
                sequence /= 10;

                sumOfElements += digit;

                if (digit == 1)
                {
                    currentSubseq++;
                }
                else
                {
                    currentSubseq = 0;
                }

                if (currentSubseq > lengthOfSubseq)
                {
                    lengthOfSubseq = currentSubseq;
                    indexOfSubseq = lengthOfSeq - i;
                }
            }

            string finalValue = lengthOfSubseq.ToString() + " " + indexOfSubseq.ToString() + " " + sumOfElements.ToString();
            return finalValue;
        }

        static bool IsFirstSeqBest(int[] seq1, int[] seq2)
        {
            if (seq1[0] > seq2[0])
            {
                //longer subseq
                return true;
            }
            else if (seq1[0] == seq2[0])
            {
                if (seq1[1] < seq2[1])
                {
                    //equal subseq and lower index
                    return true;
                }
                else if (seq1[1] == seq2[1])
                {
                    //equal subseq, equal index and bigger sum
                    if (seq1[2] > seq2[2]) return true;
                }
            }
            return false;
        }
    }
}
