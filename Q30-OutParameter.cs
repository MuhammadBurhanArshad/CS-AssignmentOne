using System;

public class NumberParser 
{ 
    public bool TryParseInt(string input, out int result) 
    { 
        if (int.TryParse(input, out result)) 
        { 
            return true; 
        } 
        else 
        { 
            result = 0; 
            return false; 
        } 
    } 
} 

class Program30
{
    static void Main()
    {
        NumberParser parser = new NumberParser();
        
        string test1 = "123";
        string test2 = "abc";
        
        if (parser.TryParseInt(test1, out int result1))
        {
            Console.WriteLine($"Successfully parsed '{test1}' as {result1}");
        }
        
        if (!parser.TryParseInt(test2, out int result2))
        {
            Console.WriteLine($"Failed to parse '{test2}', default value: {result2}");
        }
    }
}