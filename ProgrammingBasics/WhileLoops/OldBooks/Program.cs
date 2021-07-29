using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            int numberOfBooks = int.Parse(Console.ReadLine());
            string currentBook = "";
            int searchedBooks = 0;

            while (currentBook != searchedBook && searchedBooks != numberOfBooks)
            {
                currentBook = Console.ReadLine();
                searchedBooks++;
            }

            if (currentBook == searchedBook)
            {
                Console.WriteLine($"You checked {searchedBooks-1} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!\nYou checked {numberOfBooks} books.");
            }
        }
    }
}
