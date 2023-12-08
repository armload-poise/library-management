// Library.cs
using System;
using System.Collections.Generic;

public class Library
{
    private List<Book> books;
    private List<Author> authors;

    public Library()
    {
        books = new List<Book>();
        authors = new List<Author>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Books in the library:");
        foreach (var book in books)
        {
            book.DisplayInfo();
            Console.WriteLine();
        }
    }

    public void AddAuthor(Author author)
    {
        authors.Add(author);
    }

    public void DisplayAuthors()
    {
        Console.WriteLine("Authors in the library:");
        foreach (var author in authors)
        {
            author.DisplayInfo();
            Console.WriteLine();
        }
    }
}
