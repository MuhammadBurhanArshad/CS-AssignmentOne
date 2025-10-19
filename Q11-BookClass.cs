using System;

public class Book 
{ 
    public string Title; 
    public string Author; 

    public void DisplayInfo() 
    { 
        Console.WriteLine($"{Title} by {Author}"); 
    } 
}

class Program
{
    static void Main()
    {
        Book book1 = new Book();
        book1.Title = "The Great Gatsby";
        book1.Author = "F. Scott Fitzgerald";
        
        book1.DisplayInfo();
    }
}