using System;

public class Library 
{ 
    public double CalculateFine(int daysOverdue) 
    { 
        double totalFine = 0; 
        for (int day = 1; day <= daysOverdue; day++) 
        { 
            if (day <= 7) 
            { 
                totalFine += 0.10; 
            } 
            else 
            { 
                totalFine += 0.20; 
            } 
        } 
        return totalFine; 
    } 
}

class Program
{
    static void Main()
    {
        Library library = new Library();
        
        Console.WriteLine("Fine for 5 days: $" + library.CalculateFine(5));
        Console.WriteLine("Fine for 10 days: $" + library.CalculateFine(10));
        Console.WriteLine("Fine for 15 days: $" + library.CalculateFine(15));
    }
}