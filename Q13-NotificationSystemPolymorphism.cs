using System;

public class Notification 
{ 
    public virtual void Send() 
    { 
        Console.WriteLine("Sending a generic notification..."); 
    } 
} 

public class EmailNotification : Notification 
{ 
    public override void Send() 
    { 
        Console.WriteLine("Sending Email..."); 
    } 
} 

public class SMSNotification : Notification 
{ 
    public override void Send() 
    { 
        Console.WriteLine("Sending SMS..."); 
    } 
} 

class Program
{
    static void Main()
    {
        Notification email = new EmailNotification();
        Notification sms = new SMSNotification();
        
        email.Send();
        sms.Send();
    }
}