using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbersList = new List<int> { 5, -2, 0, 10, -8 }; 
        
        foreach (int num in numbersList) 
        { 
            if (num > 0) 
                Console.WriteLine("Positive"); 
            else if (num < 0) 
                Console.WriteLine("Negative"); 
            else 
            { 
                Console.WriteLine("Zero"); 
                break;
            } 
        }
    }
}