using System;

public class BookHandler 
{ 
    public void PrintBookTitle(Book book) 
    { 
        if (book == null) 
        { 
            Console.WriteLine("No book provided."); 
        } 
        else 
        { 
            Console.WriteLine(book.Title); 
        } 
    } 
} 

class Program
{
    static void Main()
    {
        BookHandler handler = new BookHandler();
        
        Book validBook = new Book();
        validBook.Title = "Valid Book Title";
        
        handler.PrintBookTitle(validBook);
        handler.PrintBookTitle(null);
    }
}