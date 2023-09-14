
using BookListLibrary;
using BookList;

List<BookModel> books = new List<BookModel>();
bool areMoreBooks = true;

Console.WriteLine("Hi! Welcome to the BookApp!");
Console.WriteLine();

do
{
    BookModel book = CreatingListLogic.GetBookInfo();
    CreatingListLogic.AddToBookList(books, book);
    areMoreBooks = AskUser.AreThereMoreBooks(areMoreBooks);

} while (areMoreBooks == true);

CreatingListLogic.ShowBookList(books);

Console.ReadLine();

