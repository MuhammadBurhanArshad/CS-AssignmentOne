using System;

public class EnhancedEmailNotification : Notification 
{ 
    public override void Send() 
    {
        base.Send();
        Console.WriteLine("Email sent successfully!"); 
    } 
} 

class Program
{
    static void Main()
    {
        EnhancedEmailNotification email = new EnhancedEmailNotification();
        email.Send();
    }
}