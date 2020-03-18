namespace Excel_Functions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            Dictionary<int, List<string>> matrix = new Dictionary<int, List<string>>();
            for (int i = 0; i < numberOfRows; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }

            List<string> command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            switch (command[0])
            {
                case "hide":
                    string colToRemove = command[1];
                    int indexToRemove = matrix[0].IndexOf(colToRemove);
                    foreach (var kvp in matrix)
                    {
                        kvp.Value.RemoveAt(indexToRemove);
                    }
                    break;
                case "sort":
                    string colToSort = command[1];
                    int indexToSort = matrix[0].IndexOf(colToSort);
                    List<string> sortCols = new List<string>();
                    for (int i = 1; i < numberOfRows; i++)
                    {
                        sortCols.Add(matrix[i][indexToSort]);
                    }
                    sortCols.Sort();
                    matrix = SortMatrix(matrix, sortCols, indexToSort);
                    break;
                case "filter":
                    string colToSearch = command[1];
                    string rowToShow = command[2];
                    int indexOfColToSearch = matrix[0].IndexOf(colToSearch);
                    Console.WriteLine(string.Join(" | ", matrix[0]));
                    foreach (var kvp in matrix)
                    {
                        if (kvp.Value[indexOfColToSearch] == rowToShow)
                        {
                            Console.WriteLine(string.Join(" | ", kvp.Value));
                        }
                    }
                    return;
                default:
                    break;
            }

            foreach (var kvp in matrix)
            {
                Console.WriteLine(string.Join(" | ", kvp.Value));
            }
        }

        private static Dictionary<int, List<string>> SortMatrix(Dictionary<int, List<string>> matrix, List<string> sortCols, int colIndex)
        {
            Dictionary<int, List<string>> returnMatrix = new Dictionary<int, List<string>>();
            returnMatrix[0] = matrix[0];
            int j = 1;
            foreach (var item in sortCols)
            {
                for (int i = 1; i < matrix.Count; i++)
                {
                    if (matrix[i][colIndex] == item)
                        returnMatrix[j] = (matrix[i]);
                }
                j++;
            }
            return returnMatrix;
        }
    }
}
