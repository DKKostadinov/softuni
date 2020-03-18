namespace Helen_s_Abduction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int numberOfRows = int.Parse(Console.ReadLine());
            Dictionary<int, List<char>> matrix = new Dictionary<int, List<char>>();
            for (int i = 0; i < numberOfRows; i++)
            {
                List<char> currentRow = Console.ReadLine()
                    .ToCharArray()
                    .ToList();
                matrix[i] = currentRow;
            }
            int parisRow = 0;
            int parisIndex = 0;
            foreach (var kvp in matrix)
            {
                if (kvp.Value.Contains('P'))
                {
                    parisRow = kvp.Key;
                    for (int i = 0; i < matrix[parisRow].Count; i++)
                    {
                        if (matrix[parisRow][i] == 'P')
                            parisIndex = i;
                    }
                    break;
                }
            }
            matrix[parisRow][parisIndex] = '-';
            while (energy > 0)
            {
                energy--;
                List<string> input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string command = input[0];
                int spawnRow = int.Parse(input[1]);
                int spawnIndex = int.Parse(input[2]);
                matrix[spawnRow][spawnIndex] = 'S';
                switch (command)
                {
                    case "up":
                        if (parisRow > 0)
                            parisRow--;
                        break;
                    case "down":
                        if (parisRow < matrix.Count - 1)
                            parisRow++;
                        break;
                    case "left":
                        if (parisIndex > 0)
                            parisIndex--;
                        break;
                    case "right":
                        if (parisIndex < matrix[parisRow].Count - 1)
                            parisIndex++;
                        break;
                    default:
                        break;
                }

                if (matrix[parisRow][parisIndex] == 'S')
                {
                    energy -= 2;
                    matrix[parisRow][parisIndex] = '-';
                }
                if (matrix[parisRow][parisIndex] == 'H')
                {
                    matrix[parisRow][parisIndex] = '-';
                    Console.Write("Paris has successfully abducted Helen! ");
                    Console.WriteLine($"Energy left: {energy}");
                    Print(matrix);
                    return;
                }
            }

            Console.WriteLine($"Paris died at {parisRow};{parisIndex}.");
            matrix[parisRow][parisIndex] = 'X';
            Print(matrix);
        }

        private static void Print(Dictionary<int, List<char>> matrix)
        {
            foreach (var kvp in matrix)
            {
                foreach (var item in kvp.Value)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
        }
    }
}
