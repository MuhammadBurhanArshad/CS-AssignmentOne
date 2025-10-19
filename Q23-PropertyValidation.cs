using System;

public class Person 
{ 
    private int _age; 
    public int Age 
    { 
        get { return _age; } 
        set 
        { 
            if (value >= 0 && value <= 120) 
            { 
                _age = value; 
            } 
            else 
            { 
                _age = 0; 
            } 
        } 
    } 
} 

class Program
{
    static void Main()
    {
        Person person = new Person();
        
        person.Age = 25;
        Console.WriteLine($"Valid age: {person.Age}");
        
        person.Age = 150;
        Console.WriteLine($"Invalid age becomes: {person.Age}");
        
        person.Age = -5;
        Console.WriteLine($"Negative age becomes: {person.Age}");
    }
}