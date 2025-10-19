using System;

public class Greeter 
{ 
    public void Greet(string name) 
    { 
        Console.WriteLine($"Hello, {name}"); 
    } 

    public void Greet(string name, string time) 
    { 
        Console.WriteLine($"Good {time}, {name}"); 
    } 
} 

class Program
{
    static void Main()
    {
        Greeter greeter = new Greeter();
        
        greeter.Greet("Alice");
        greeter.Greet("Bob", "morning");
    }
}