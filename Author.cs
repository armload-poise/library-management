// Author.cs
using System;

public class Author
{
    public string Name { get; set; }
    public string Country { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Country: {Country}");
    }
}
