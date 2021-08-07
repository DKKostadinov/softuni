using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine()) % arr.Length;
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int newIndex = i - rotations;
                if (newIndex < 0) newIndex += arr.Length;
                newArr[newIndex] = arr[i];
            }
            foreach (var item in newArr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
