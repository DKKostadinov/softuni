namespace Space_Station_Establishment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            List<List<char>> matrix = new List<List<char>>();
            for (int i = 0; i < size; i++)
            {
                List<char> inputList = new List<char>(Console.ReadLine());
                matrix.Add(inputList);
            }

            int xStephen = -1;
            int yStephen = -1;
            int xFirstHole = -1;
            int xSecondHole = -1;
            int yFirstHole = -1;
            int ySecondHole = -1;

            int energy = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    if (matrix[i][j] == 'S')
                    {
                        xStephen = i;
                        yStephen = j;
                        matrix[i][j] = '-';
                    }
                    if (matrix[i][j] == 'O' && xFirstHole == -1 && yFirstHole == -1)
                    {
                        xFirstHole = i;
                        yFirstHole = j;
                    }
                    if (matrix[i][j] == 'O' && xFirstHole != -1 && yFirstHole != -1)
                    {
                        xSecondHole = i;
                        ySecondHole = j;
                    }
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "up":
                        xStephen--;
                        break;
                    case "down":
                        xStephen++;
                        break;
                    case "left":
                        yStephen--;
                        break;
                    case "right":
                        yStephen++;
                        break;
                    default:
                        break;
                }
                if (xStephen < 0 || xStephen >= size || yStephen < 0 || yStephen >= matrix[xStephen].Count)
                {
                    break;
                }
                else if (xStephen == xFirstHole && yStephen == yFirstHole)
                {
                    xStephen = xSecondHole;
                    yStephen = ySecondHole;
                    matrix[xFirstHole][yFirstHole] = '-';
                    matrix[xSecondHole][ySecondHole] = '-';
                }
                else if (xStephen == xSecondHole && yStephen == ySecondHole)
                {
                    xStephen = xFirstHole;
                    yStephen = yFirstHole;
                    matrix[xFirstHole][yFirstHole] = '-';
                    matrix[xSecondHole][ySecondHole] = '-';
                }
                else if (matrix[xStephen][yStephen] != '-' && matrix[xStephen][yStephen] != 'S' && matrix[xStephen][yStephen] != 'O')
                {
                    string star = matrix[xStephen][yStephen].ToString();
                    energy += int.Parse(star);
                    matrix[xStephen][yStephen] = '-';
                }

                if (energy >= 50)
                {
                    matrix[xStephen][yStephen] = 'S';
                    Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                    Console.WriteLine($"Star power collected: {energy}");
                    Print(matrix);
                    return;

                }
            }
            Console.WriteLine("Bad news, the spaceship went to the void.");
            Console.WriteLine($"Star power collected: {energy}");
            Print(matrix);
        }

        private static void Print(List<List<char>> matrix)
        {
            foreach (var list in matrix)
            {
                foreach (var item in list)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
        }
    }
}
