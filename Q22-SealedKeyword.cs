using System;

public class Employee 
{ 
    public string Name; 
} 

public sealed class CEO : Employee 
{ 
    public double Bonus; 
} 

class Program
{
    static void Main()
    {
        CEO ceo = new CEO();
        ceo.Name = "John Smith";
        ceo.Bonus = 50000;
        
        Console.WriteLine($"CEO: {ceo.Name}, Bonus: ${ceo.Bonus}");
    }
}