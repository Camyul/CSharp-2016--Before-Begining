using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        long number = Convert.ToInt64(Console.ReadLine());
        List<int> binariDigits = new List<int>();
        string binariNumber = null;
        while (number >= 1)
        {
            binariDigits.Add((int)(number % 2));
            number /= 2;
        }
        for (int i = binariDigits.Count - 1; i >= 0; i--)
        {
            binariNumber += binariDigits[i];
        }
        Console.WriteLine(binariNumber);
    }
}