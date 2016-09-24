using System;
class Program
{
    static void Main()
    {
        string typeVariable = Console.ReadLine();
        if (typeVariable == "integer")
        {
            int intNumber = Convert.ToInt32(Console.ReadLine());
            intNumber++;
            Console.WriteLine(intNumber);
        }
        else if (typeVariable == "real")
        {
            double doubleNumber = Convert.ToDouble(Console.ReadLine());
            doubleNumber += 1;
            Console.WriteLine("{0:F2}", doubleNumber);
        }
        else
        {
            string frase = Console.ReadLine();
            Console.WriteLine(frase + "*");
        }
    }
}