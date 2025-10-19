using System;

public class Student 
{ 
    public string Name; 
    public int Id; 

    public Student(string name, int id) 
    { 
        Name = name; 
        Id = id; 
    } 

    public Student(string name) : this(name, 0)
    { 
    } 
} 

class Program
{
    static void Main()
    {
        Student student1 = new Student("Alice", 101);
        Student student2 = new Student("Bob"); 
        
        Console.WriteLine($"Student 1: {student1.Name}, ID: {student1.Id}");
        Console.WriteLine($"Student 2: {student2.Name}, ID: {student2.Id}");
    }
}