
using BookListLibrary;
using BookList;

List<BookModel> books = new List<BookModel>();
bool areMoreBooks = true;

//Writing a welcome message

Console.WriteLine("Hi! Welcome to the BookApp!");
Console.WriteLine("In this app you can create a list of the books you own.");
Console.WriteLine("It will include titles of the book, authors and nubers of pages.\n");
Console.WriteLine("Press any key to continue.");
Console.ReadLine();

//Getting book informations

do
{
    BookModel book = CreatingListLogic.GetBookInfo();
    CreatingListLogic.AddToBookList(books, book);
    areMoreBooks = AskUser.AreThereMoreBooks(areMoreBooks);

} while (areMoreBooks == true);

//showing the list of books

CreatingListLogic.ShowBookList(books);

Console.WriteLine("\n\n\nTo exit the aplication press any key.");
Console.ReadLine();

