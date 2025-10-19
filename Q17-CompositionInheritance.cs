using System;

public class Engine 
{ 
    public string Type; 
} 

public class Car 
{ 
    public Engine CarEngine;
    public string Model; 
} 

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Model = "Toyota Camry";
        myCar.CarEngine = new Engine();
        myCar.CarEngine.Type = "V6";
        
        Console.WriteLine($"Car: {myCar.Model}, Engine: {myCar.CarEngine.Type}");
    }
}