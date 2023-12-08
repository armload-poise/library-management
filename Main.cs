// Main.cs
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Library library = new Library();

        // Create authors
        Author author1 = new Author { Name = "John Doe", Country = "USA" };
        Author author2 = new Author { Name = "Jane Smith", Country = "UK" };

        // Create books
        Book book1 = new Book { Title = "Introduction to C#", Author = "John Doe", Year = 2022 };
        Book book2 = new Book { Title = "Advanced C# Programming", Author = "Jane Smith", Year = 2023 };

        // Add authors and books to the library
        library.AddAuthor(author1);
        library.AddAuthor(author2);
        library.AddBook(book1);
        library.AddBook(book2);

        // Display library information
        library.DisplayAuthors();
        Console.WriteLine(new string('-', 30));
        library.DisplayBooks();
    }
}
