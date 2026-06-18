// now i will make a library system to practice oop in c# 

//after classes i create objects

/* book objects */

Book book1 = new Book();
book1.title = "Harry Pottter";
book1.author = "author1";
book1.pages = 500;

Book book2 = new Book();
book2.title = "Second book";
book2.author = "Ayşe";
book2.pages = 123;

Book book3 = new Book();
book3.title = "abc book";
book3.author = "ali";
book3.pages = 111;

/* library objets */
Library library = new Library();
library.books.Add(book1);
library.books.Add(book2);           
library.books.Add(book3);

library.print();

Console.WriteLine("Whats ur name?"); 
string memberName = Console.ReadLine();
LibraryMember member = new LibraryMember();
member.name = memberName;

library.members.Add(member); // i added the member to library

Console.WriteLine("choose a book");
string BorrowedBook = Console.ReadLine();
bool found = false;
foreach (Book book in library.books)
{
if (book.title == BorrowedBook)
{
    library.BorrowBook(member, book);
    found = true;
    break;
}
}
if (!found) 
{
Console.WriteLine("we dont have this book now ");
}


Console.WriteLine("do u want to return a book type yes or no");
string answer = Console.ReadLine();
if (answer == "yes")
{
    Console.WriteLine("write the name of the book pls");

 string returnedBook = Console.ReadLine();
    bool isReturned = false;
    foreach (Book book in member.borrowedBooks)
  {
   if (book.title == returnedBook)
   {
    library.ReturnBook(member, book);
    isReturned = true;
    break;
   } 
  }
   if (!isReturned)
   {
    Console.WriteLine("this book is not borrowed from thislibrary");
   }
  }




class Book
{
    public string title;
    public string author;
    public int pages;

    public void print() // my method 
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Pages: {pages}");
    }
} 

class LibraryMember 
{
    public string name;
    public int memberId;
    public List<Book> borrowedBooks = new List<Book>(); //i used empty list because no one has books in the beginning 
    
    public void print()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Member ID: {memberId}");
        Console.WriteLine("Borrowed Books:");
    }
}
class Library{
    public List<Book> books = new List<Book>();
    public List<LibraryMember> members = new List<LibraryMember>();

    public void print()
    {
        Console.WriteLine("available books:");
        foreach (Book book in books)
        {
            book.print();
        }   
  }
public void BorrowBook(LibraryMember member , Book book)
{
books.Remove(book);
   member.borrowedBooks.Add(book);
Console.WriteLine($"{member.name} borrowed {book.title}");
}
public void ReturnBook (LibraryMember member, Book book)
{
    member.borrowedBooks.Remove(book);
    books.Add(book);
    Console.WriteLine($"{member.name} returned {book.title}");
}
}