using System;

public class SentenceFormatter 
{ 
    public string FormatSentence(string input) 
    { 
        string[] words = input.ToLower().Split(' '); 
        for (int i = 0; i < words.Length; i++) 
        { 
            if (words[i].Length > 0) 
            { 
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1); 
            } 
        } 
        return string.Join(" ", words); 
    } 
}

class Program
{
    static void Main()
    {
        SentenceFormatter formatter = new SentenceFormatter();
        
        string input = "thIs iS a sTriNg";
        string result = formatter.FormatSentence(input);
        
        Console.WriteLine("Original: " + input);
        Console.WriteLine("Formatted: " + result);
    }
}