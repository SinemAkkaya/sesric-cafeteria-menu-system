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


// my classes 
class Book
{
    public string title;
    public string author;
    public int pages;

    public void print()
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
}
