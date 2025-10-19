using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> secretCode = new List<int>(); 
        Random rand = new Random(); 
        
        while (secretCode.Count < 10) 
        { 
            int num = rand.Next(1, 101); 
            if (num % 2 == 0) 
            { 
                secretCode.Add(num); 
            } 
        } 
        
        Console.WriteLine("Secret Code (10 even numbers): " + string.Join(", ", secretCode));
    }
}