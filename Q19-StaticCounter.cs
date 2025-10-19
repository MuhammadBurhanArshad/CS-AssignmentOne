using System;

public class Player 
{ 
    public static int PlayerCount = 0; 
    public string Name; 

    public Player(string name) 
    { 
        Name = name; 
        PlayerCount++;
    } 
} 

class Program
{
    static void Main()
    {
        Console.WriteLine($"Initial player count: {Player.PlayerCount}");
        
        Player player1 = new Player("Alice");
        Player player2 = new Player("Bob");
        Player player3 = new Player("Charlie");
        
        Console.WriteLine($"Total players created: {Player.PlayerCount}");
    }
}