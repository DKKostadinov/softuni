using System;

namespace RecursiveDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Draw(input);
        }

        private static void Draw(int input)
        {
            DrawTopPart(input);
            DrawBottomPart(input, 1);
        }

        private static void DrawTopPart(int input)
        {
            if (input == 1)
            {
                Console.WriteLine("*");
                return;
            }
            Console.WriteLine(new string('*', input));
            DrawTopPart(input-1);
        }

        private static void DrawBottomPart(int input, int number)
        {
            if (input == number)
            {
                Console.WriteLine(new string('#', number));
                return;
            }

            Console.WriteLine(new string('#', number));
            DrawBottomPart(input, number+1);
        }
    }
}
