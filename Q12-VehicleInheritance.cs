using System;

public class Vehicle 
{ 
    public int Speed; 
} 

public class Car : Vehicle 
{ 
    public int NumDoors; 
} 

public class Bicycle : Vehicle 
{ 
    public bool HasBell; 
} 

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Speed = 60;
        myCar.NumDoors = 4;
        
        Bicycle myBike = new Bicycle();
        myBike.Speed = 15;
        myBike.HasBell = true;
        
        Console.WriteLine($"Car: {myCar.Speed} mph, {myCar.NumDoors} doors");
        Console.WriteLine($"Bicycle: {myBike.Speed} mph, Has bell: {myBike.HasBell}");
    }
}