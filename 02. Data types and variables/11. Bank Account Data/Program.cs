using System;

class Program
{
    static void Main()
    {
        Console.Write("First Name: ");
        string nameFirst = Console.ReadLine();
        Console.Write("Middle Name: ");
        string nameMiddle = Console.ReadLine();
        Console.Write("Last Name: ");
        string nameLast = Console.ReadLine();
        Console.Write("Balance:");
        decimal moneyBalance = decimal.Parse(Console.ReadLine());
        Console.Write("Bank Name: ");
        string nameBank = Console.ReadLine();
        Console.Write("IBAN: ");
        string ibanNumber = Console.ReadLine();
        Console.Write("First Credit Card Number: ");
        long cardNumber1 = long.Parse(Console.ReadLine());
        Console.Write("Second Credit Card Number: ");
        long cardNumber2 = long.Parse(Console.ReadLine());
        Console.Write("Third Credit Card Number: ");
        long cardNumber3 = long.Parse(Console.ReadLine());
        Console.WriteLine("First Name: {0}", nameFirst);
        Console.WriteLine("Middle Name: {0}", nameMiddle);
        Console.WriteLine("Last Name: {0}", nameLast);
        Console.WriteLine("Accaunt Balance: {0}", moneyBalance);
        Console.WriteLine("Bank Name: {0}", nameBank);
        Console.WriteLine("IBAN: {0}", nameFirst);
        Console.WriteLine("First Credit Card Number: {0}", cardNumber1);
        Console.WriteLine("Second Credit Card Number: {0}", cardNumber2);
        Console.WriteLine("Third Credit Card Number: {0}", cardNumber3);
    }
}
