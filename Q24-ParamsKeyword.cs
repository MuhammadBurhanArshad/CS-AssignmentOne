using System;

public class Fruits 
{ 
    public void PrintFruit(params string[] fruits) 
    { 
        Console.WriteLine(string.Join(" | ", fruits)); 
    } 
} 

class Program
{
    static void Main()
    {
        Fruits fruitPrinter = new Fruits();
        
        fruitPrinter.PrintFruit("Apple");
        fruitPrinter.PrintFruit("Banana", "Orange");
        fruitPrinter.PrintFruit("Grape", "Strawberry", "Blueberry", "Raspberry");
    }
}