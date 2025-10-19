using System;

public abstract class Shape 
{ 
    public abstract double CalculateArea(); 
} 

public class Square : Shape 
{ 
    public double SideLength; 
    public override double CalculateArea() 
    { 
        return SideLength * SideLength; 
    } 
} 

class Program
{
    static void Main()
    {
        Square square = new Square();
        square.SideLength = 5;
        
        Console.WriteLine($"Square area: {square.CalculateArea()}");
    }
}