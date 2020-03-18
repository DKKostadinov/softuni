using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCharactersInRange(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()));
        }

        static void PrintCharactersInRange(char begginingCharacter, char endingCharacter)
        {
            if (begginingCharacter < endingCharacter)
            {
                for (int i = begginingCharacter + 1; i < endingCharacter; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = endingCharacter + 1; i < begginingCharacter; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
                  
        }
    }
}
