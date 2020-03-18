using System;
using System.Linq;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
            string input = string.Empty;
            while (true)
            {
                input = Console.ReadLine();
                string[] inputStringArray = input.Split(" ").ToArray();
                switch (inputStringArray[0])
                {
                    case "exchange":
                        if (int.Parse(inputStringArray[1]) >= inputArray.Length)
                            Console.WriteLine("Invalid index");
                        else
                            inputArray = CommandExchange(inputArray, int.Parse(inputStringArray[1]));
                        break;
                    case "max":
                        if (inputStringArray[1] == "even") CommandMaxEven(inputArray);
                        else CommandMaxOdd(inputArray);
                        break;
                    case "min":
                        if (inputStringArray[1] == "even") CommandMinEven(inputArray);
                        else CommandMinOdd(inputArray);
                        break;
                    case "first":
                        if (int.Parse(inputStringArray[1]) >= inputArray.Length)
                            Console.WriteLine("Invalid count");
                        else
                        {
                            if (inputStringArray[2] == "even") CommandFirstEven(inputArray, int.Parse(inputStringArray[1]));
                            else CommandFirstOdd(inputArray, int.Parse(inputStringArray[1]));
                        }
                        break;
                    case "last":
                        if (inputStringArray[2] == "even") CommandLastEven(inputArray, int.Parse(inputStringArray[1]));
                        else CommandLastOdd(inputArray, int.Parse(inputStringArray[1]));
                        break;
                    case "end":
                        Console.Write("[");
                        for (int i = 0; i < inputArray.Length - 1; i++)
                        {
                            Console.Write(inputArray[i] + ", ");
                        }
                        Console.Write(inputArray[inputArray.Length - 1] + "]");
                        Console.WriteLine();
                        return;
                    default:
                        break;
                }
            }
        }

        private static void CommandLastOdd(int[] inputArray, int numberOfOdd)
        {
            int[] arayOfLastOdd = new int[numberOfOdd];
            int oddNumberCounter = 0;
            Console.Write("[");
            for (int i = inputArray.Length - 1; i > -1; i--)
            {
                if (inputArray[i] % 2 == 1)
                {
                    arayOfLastOdd[oddNumberCounter] = inputArray[i];
                    oddNumberCounter++;
                }
                if (oddNumberCounter == numberOfOdd)
                    break;
            }
            arayOfLastOdd.Reverse();
            for (int i = 0; i < oddNumberCounter; i++)
            {
                if (i < oddNumberCounter - 1)
                    Console.Write(arayOfLastOdd[i] + ", ");
                else
                    Console.Write(arayOfLastOdd[i]);
            }
            Console.Write("]\n");
        }

        private static void CommandLastEven(int[] inputArray, int numberOfEven)
        {
            int[] arrayOfLastEven = new int[numberOfEven];
            int evenNumberCounter = 0;
            Console.Write("[");
            for (int i = inputArray.Length - 1; i > -1; i--)
            {
                if (inputArray[i] % 2 == 0)
                {
                    arrayOfLastEven[evenNumberCounter] = inputArray[i];
                    evenNumberCounter++;
                }
                if (evenNumberCounter == numberOfEven)
                    break;
            }
            arrayOfLastEven.Reverse();
            for (int i = 0; i < evenNumberCounter; i++)
            {
                if (i < evenNumberCounter - 1)
                    Console.Write(arrayOfLastEven[i] + ", ");
                else
                    Console.Write(arrayOfLastEven[i]);
            }
            Console.Write("]\n");
        }

        private static void CommandFirstOdd(int[] inputArray, int numberOfOdd)
        {
            int[] arrayOfFirstOdd = new int[numberOfOdd];
            int oddNumberCounter = 0;
            Console.Write("[");
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] % 2 == 1)
                {
                    arrayOfFirstOdd[oddNumberCounter] = inputArray[i];
                    oddNumberCounter++;
                }
                if (oddNumberCounter == numberOfOdd)
                    break;
            }
            for (int i = 0; i < oddNumberCounter; i++)
            {
                if (i < oddNumberCounter - 1)
                    Console.Write(arrayOfFirstOdd[i] + ", ");
                else
                    Console.Write(arrayOfFirstOdd[i]);
            }
            Console.Write("]\n");
        }

        private static void CommandFirstEven(int[] inputArray, int numberOfEven)
        {
            int[] arrayOfFirstEven = new int[numberOfEven];
            int evenNumberCounter = 0;
            Console.Write("[");
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] % 2 == 0)
                {
                    arrayOfFirstEven[evenNumberCounter] = inputArray[i];
                    evenNumberCounter++;
                }
                if (evenNumberCounter == numberOfEven)
                    break;
            }
            for (int i = 0; i < evenNumberCounter; i++)
            {
                if (i < evenNumberCounter - 1)
                    Console.Write(arrayOfFirstEven[i] + ", ");
                else
                    Console.Write(arrayOfFirstEven[i]);
            }
            Console.Write("]\n");
        }

        private static void CommandMinOdd(int[] inputArray)
        {
            int minOdd = int.MaxValue;
            int minOddIndex = -1;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] % 2 == 1 && inputArray[i] < minOdd)
                {
                    minOdd = inputArray[i];
                    minOddIndex = i;
                }
            }
            if (minOdd != int.MaxValue) Console.WriteLine(minOddIndex);
            else Console.WriteLine("No matches");
        }

        private static void CommandMinEven(int[] inputArray)
        {
            int minEven = int.MaxValue;
            int minEvenIndex = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] % 2 == 0 && inputArray[i] < minEven)
                {
                    minEven = inputArray[i];
                    minEvenIndex = i;
                }
            }
            if (minEven != int.MaxValue) Console.WriteLine(minEvenIndex);
            else Console.WriteLine("No matches");
        }

        private static void CommandMaxOdd(int[] inputArray)
        {
            int maxOdd = int.MinValue;
            int maxOddIndex = -1;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] % 2 == 1 && inputArray[i] > maxOdd)
                {
                    maxOdd = inputArray[i];
                    maxOddIndex = i;
                }
            }
            if (maxOdd != int.MinValue) Console.WriteLine(maxOddIndex);
            else Console.WriteLine("No matches");
        }

        private static void CommandMaxEven(int[] inputArray)
        {
            int maxEven = int.MinValue;
            int maxEvenIndex = -1;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] % 2 == 0 && inputArray[i] > maxEven)
                {
                    maxEven = inputArray[i];
                    maxEvenIndex = i;
                }
            }
            if (maxEven != int.MinValue) Console.WriteLine(maxEvenIndex);
            else Console.WriteLine("No matches");
        }

        static int[] CommandExchange(int[] inputArray, int numberOfRotations)
        {
            for (int i = 0; i <= numberOfRotations; i++)
            {
                for (int j = 0; j < inputArray.Length - 1; j++)
                {
                    int temp = inputArray[j];
                    inputArray[j] = inputArray[j + 1];
                    inputArray[j + 1] = temp;
                }
            }
            return inputArray;
        }
    }
}
