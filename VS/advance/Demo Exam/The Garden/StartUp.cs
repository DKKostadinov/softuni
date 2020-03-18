namespace The_Garden
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            Dictionary<int, List<char>> garden = new Dictionary<int, List<char>>();
            int cCount = 0;
            int lCount = 0;
            int pCount = 0;
            int harmedVeg = 0;

            for (int i = 0; i < rows; i++)
            {
                List<char> currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToList();
                garden[i] = currentRow;
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End of Harvest")
                    break;
                List<string> command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (command[0] == "Harvest")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    if (row < 0 || row >= rows || col < 0 || col >= garden[row].Count) continue;
                    if (garden[row][col] == 'C') cCount++;
                    if (garden[row][col] == 'P') pCount++;
                    if (garden[row][col] == 'L') lCount++;
                    garden[row][col] = ' ';
                }
                if (command[0] == "Mole")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    if (row < 0 || row >= rows || col < 0 || col >= garden[row].Count) continue;
                    string direction = command[3];
                    switch (direction)
                    {
                        case "up":
                            for (int i = row; i >= 0; i -= 2)
                            {
                                if(garden[i][col] != ' ')
                                {
                                    garden[i][col] = ' ';
                                    harmedVeg++;
                                }
                            }
                            break;
                        case "down":
                            for (int i = row; i < rows; i += 2)
                            {
                                if (garden[i][col] != ' ')
                                {
                                    garden[i][col] = ' ';
                                    harmedVeg++;
                                }
                            }
                            break;
                        case "left":
                            for (int i = col; i >= 0; i -= 2)
                            {
                                if (garden[row][i] != ' ')
                                {
                                    garden[row][i] = ' ';
                                    harmedVeg++;
                                }
                            }
                            break;
                        case "right":
                            for (int i = col; i < garden[row].Count; i += 2)
                            {
                                if (garden[row][i] != ' ')
                                {
                                    garden[row][i] = ' ';
                                    harmedVeg++;
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
            }

            foreach (var row in garden)
            {
                foreach (var col in row.Value)
                {
                    Console.Write($"{col} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Carrots: {cCount}");
            Console.WriteLine($"Potatoes: {pCount}");
            Console.WriteLine($"Lettuce: {lCount}");
            Console.WriteLine($"Harmed vegetables: {harmedVeg}");
        }
    }
}
