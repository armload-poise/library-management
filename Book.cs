// Book.cs
using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Year: {Year}");
    }
}
