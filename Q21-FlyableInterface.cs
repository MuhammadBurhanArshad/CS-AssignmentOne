using System;

public interface IFlyable 
{ 
    void Fly(); 
} 

public class Airplane : IFlyable 
{ 
    public void Fly() 
    { 
        Console.WriteLine("The airplane flies using jet engines."); 
    } 
} 

public class Bird : IFlyable 
{ 
    public void Fly() 
    { 
        Console.WriteLine("The bird flies by flapping its wings."); 
    } 
} 

class Program
{
    static void Main()
    {
        IFlyable airplane = new Airplane();
        IFlyable bird = new Bird();
        
        airplane.Fly();
        bird.Fly();
    }
}