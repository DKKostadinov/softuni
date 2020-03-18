using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int numberOfBooks = int.Parse(Console.ReadLine());
            string currentBook = string.Empty;
            int searchedBooks = 0;

            for (searchedBooks = 0; searchedBooks < numberOfBooks; searchedBooks++)
            {
                currentBook = Console.ReadLine();
                if (currentBook == book)
                {
                    Console.WriteLine($"You checked {searchedBooks} books and found it.");
                    break;
                }
            }
            if (numberOfBooks == searchedBooks) Console.WriteLine($"The book you search is not here!\nYou checked {searchedBooks} books.");
        }
    }
}
