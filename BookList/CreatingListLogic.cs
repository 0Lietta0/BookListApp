using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList
{
    using BookListLibrary;
    internal class CreatingListLogic
    {
        public static BookModel GetBookInfo()
        {
            Console.Clear();

            BookListLibrary.BookModel book = new BookListLibrary.BookModel();
            book.Author = AskUser.GetInfoFromConsole("Write the author of the book: ");
            book.Title = AskUser.GetInfoFromConsole("Write the title of the book: ");

            //GetNumberOfPages
            int numberOfPages = 0;
            do
            {
                string numberOfPagesText = AskUser.GetInfoFromConsole("Write the number of pages in the book: ");
                if (int.TryParse(numberOfPagesText, out numberOfPages))
                {
                    if (numberOfPages > 1 && numberOfPages < 10000)
                    {
                        book.NumberOfPages = numberOfPages;
                    }
                    else
                    {
                        Console.WriteLine("The number of pages is incorrect.");
                    }
                }
                else
                {
                    Console.WriteLine("This was not a digit number.");
                }

            } while (numberOfPages == 0);

            return book;
        }

        public static void AddToBookList(List<BookModel> bookList, BookModel book)
        {
            bookList.Add(book);
        }

        public static void ShowBookList(List<BookModel> bookList)
        {
            Console.Clear();
            Console.WriteLine("List of your books:");
            Console.WriteLine();
            foreach (BookModel book in bookList)
            {
                Console.WriteLine(book.BookFullInfo);
            }
        }
    }
}
