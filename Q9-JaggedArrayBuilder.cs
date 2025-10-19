using System;

class Program
{
    static void Main()
    {
        string[][] subjects = new string[3][]; 
        subjects[0] = new string[] { "Science" }; 
        subjects[1] = new string[] { "Math", "Physics" }; 
        subjects[2] = new string[] { "Chemistry", "Biology", "Geology" }; 
        
        Console.WriteLine("All subjects:");
        for (int i = 0; i < subjects.Length; i++) 
        { 
            foreach (string subject in subjects[i]) 
            { 
                Console.WriteLine(subject); 
            } 
        }
    }
}