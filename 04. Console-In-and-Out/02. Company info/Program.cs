using System;


class Program
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAdress = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        string webSait = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        string managerAge = Console.ReadLine();
        string managerPhoneNumber = Console.ReadLine();
        if (faxNumber.Length == 0)
        {
            faxNumber = "(no fax)";
        }
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAdress);
        Console.WriteLine("Tel. {0}", phoneNumber);
        Console.WriteLine("Fax: {0}", faxNumber);
        Console.WriteLine("Web site: {0}", webSait);
        Console.Write("Manager: {0} {1}", managerFirstName, managerLastName);
        Console.WriteLine(" (age: {0}, tel. {1})", managerAge, managerPhoneNumber);
    }
}
