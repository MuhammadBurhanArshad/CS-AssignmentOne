using System;

public class DiscountApplicator 
{ 
    public double ApplyDiscount(double price, string customerType) 
    { 
        switch (customerType.ToLower()) 
        { 
            case "member": 
                return price * 0.9; 
            case "vip": 
                return price * 0.8; 
            case "regular": 
            default: 
                return price; 
        } 
    } 
}

class Program
{
    static void Main()
    {
        DiscountApplicator store = new DiscountApplicator();
        
        double price = 100.0;
        Console.WriteLine($"Regular customer: ${store.ApplyDiscount(price, "regular")}");
        Console.WriteLine($"Member customer: ${store.ApplyDiscount(price, "member")}");
        Console.WriteLine($"VIP customer: ${store.ApplyDiscount(price, "vip")}");
        Console.WriteLine($"Unknown customer: ${store.ApplyDiscount(price, "unknown")}");
    }
}