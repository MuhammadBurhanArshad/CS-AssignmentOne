using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Notification> notifications = new List<Notification>(); 
        notifications.Add(new EmailNotification()); 
        notifications.Add(new SMSNotification()); 

        foreach (Notification n in notifications) 
        { 
            n.Send(); 
        } 
    }
}