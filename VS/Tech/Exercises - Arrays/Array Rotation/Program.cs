using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] newArray = new int[input.Length];

            newArray = ArrayRotation(input, rotations);

            foreach (var item in newArray)
            {
                Console.Write(item + " ");
            }

        }

        static int[] OneArrayRotation(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int temp = inputArray[i];
                inputArray[i] = inputArray[i + 1];
                inputArray[i + 1] = temp;
            }
            return inputArray;
        }

        static int[] ArrayRotation(int[] inputArray, int numberOfRotations)
        {
            for (int i = 0; i < numberOfRotations; i++)
            {
                inputArray = OneArrayRotation(inputArray);
            }
            return inputArray;
        }
    }
}
