using System;

class Program
{
    static void Main()
    {
        Console.Write("First Name: ");
        string nameFirst = Console.ReadLine();
        Console.Write("Last Name: ");
        string nameLast = Console.ReadLine();
        Console.Write("Age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Personal ID: ");
        long personalID = long.Parse(Console.ReadLine());
        int employerNumber = 27560000;        
        Console.WriteLine(nameFirst);
        Console.WriteLine(nameLast);
        Console.WriteLine(age);
        Console.WriteLine(personalID);
        Console.WriteLine(employerNumber);
        employerNumber++;
    }
}
