using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> existingUsernames = new List<string>() { "alice", "bob", "charlie" }; 
        string newUsername = "alice"; 

        string proposedUsername = newUsername; 
        int counter = 1; 

        while (existingUsernames.Contains(proposedUsername)) 
        { 
            proposedUsername = newUsername + counter; 
            counter++; 
        } 

        Console.WriteLine($"Your unique username is: {proposedUsername}");
        
        existingUsernames.Add(proposedUsername);
        Console.WriteLine("All usernames: " + string.Join(", ", existingUsernames));
    }
}