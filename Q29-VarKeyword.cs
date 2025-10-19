using System;
using System.Collections.Generic;

class Program29
{
    static void Main()
    {
        List<double> temperatures = new List<double> { 72.5, 68.3, 75.1, 80.9, 65.7, 70.2, 78.4 }; 

        Console.WriteLine("Using explicit typing (double):");
        foreach (double temp in temperatures) 
        { 
            string weatherEmoji = temp >= 75 ? "🔥" : temp >= 70 ? "☀️" : "❄️"; 
            Console.WriteLine($"{weatherEmoji} Temperature: {temp}°F"); 
        } 

        Console.WriteLine("\nUsing implicit typing (var):"); 
        foreach (var temp in temperatures) 
        { 
            string weatherEmoji = temp >= 75 ? "🔥" : temp >= 70 ? "☀️" : "❄️"; 
            Console.WriteLine($"{weatherEmoji} Temperature: {temp}°F"); 
        }
    }
}