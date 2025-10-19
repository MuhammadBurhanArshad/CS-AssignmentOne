using System;

public class Product 
{ 
    public string Name { get; set; } 
    public double Price { get; set; } 
} 

class Program
{
    static void Main()
    {
        Product p1 = new Product { Name = "Coffee", Price = 2.99 }; 
        Product p2 = new Product { Name = "Tea", Price = 1.99 };
        
        Console.WriteLine($"Product 1: {p1.Name} - ${p1.Price}");
        Console.WriteLine($"Product 2: {p2.Name} - ${p2.Price}");
    }
}