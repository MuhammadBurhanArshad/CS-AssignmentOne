using System;

class Program
{
    static void Main()
    {
        Vehicle myVehicle = new Car();
        
        Car myCar = myVehicle as Car; 
        if (myCar != null) 
        { 
            Console.WriteLine($"Using 'as': This car has {myCar.NumDoors} doors."); 
        } 
        
        if (myVehicle is Car safeCar) 
        { 
            Console.WriteLine($"Using 'is': This car has {safeCar.NumDoors} doors."); 
        }
        
        Vehicle myBicycle = new Bicycle();
        if (myBicycle is Car)
        {
            Console.WriteLine("This is a car");
        }
        else
        {
            Console.WriteLine("This is not a car");
        }
    }
}