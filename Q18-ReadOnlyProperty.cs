using System;

public class BankAccount 
{ 
    public readonly string AccountNumber;

    public BankAccount(string accountNumber) 
    { 
        AccountNumber = accountNumber;
    } 
} 

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount("123456789");
        Console.WriteLine($"Account Number: {account.AccountNumber}");
    }
}