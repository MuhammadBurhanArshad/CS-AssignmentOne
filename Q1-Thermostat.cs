using System;

public class Thermostat 
{ 
    public int SetTemperature(int newTemp) 
    { 
        if (newTemp < 10 || newTemp > 35) 
        { 
            return 20;
        } 
        else 
        { 
            return newTemp; 
        } 
    } 
}

class Program
{
    static void Main()
    {
        Thermostat thermostat = new Thermostat();
        
        Console.WriteLine("Setting temperature to 25: " + thermostat.SetTemperature(25));
        Console.WriteLine("Setting temperature to 5: " + thermostat.SetTemperature(5));
        Console.WriteLine("Setting temperature to 40: " + thermostat.SetTemperature(40));
    }
}