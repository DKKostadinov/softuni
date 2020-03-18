using System;
using System.Text;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    sb.Append(input[i]);
                    int j = i + 1;
                    int jLoopLength = j + int.Parse(input[i + 1].ToString());
                    if (jLoopLength > input.Length)
                        jLoopLength = input.Length;
                    for (j = i + 1; j < jLoopLength; j++)
                    {
                        if (input[j] == '>')
                        {
                            sb.Append(input[j]);
                            jLoopLength += int.Parse(input[j + 1].ToString()) + 1;
                            if (jLoopLength > input.Length)
                                jLoopLength = input.Length;
                        }
                    }
                    i = j - 1;
                }
                else
                {
                    sb.Append(input[i]);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
