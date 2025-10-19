using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 }; 
        
        Console.WriteLine("Original array: " + string.Join(", ", numbers));
        
        for (int i = 0; i < numbers.Length / 2; i++) 
        { 
            int temp = numbers[i]; 
            numbers[i] = numbers[numbers.Length - 1 - i]; 
            numbers[numbers.Length - 1 - i] = temp; 
        } 
        
        Console.WriteLine("Reversed array: " + string.Join(", ", numbers));
    }
}