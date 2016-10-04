using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        long number = Convert.ToInt64(Console.ReadLine());
        List<string> hexDigit = new List<string>();
        string hexNumber = null;
        while (number >= 1)
        {
            if ((number % 16) > 9)
            {
                switch (number % 16)
                {
                    case 10: hexDigit.Add("A"); break;
                    case 11: hexDigit.Add("B"); break;
                    case 12: hexDigit.Add("C"); break;
                    case 13: hexDigit.Add("D"); break;
                    case 14: hexDigit.Add("E"); break;
                    case 15: hexDigit.Add("F"); break;
                    default:
                        break;
                }
            }
            else
            {
               hexDigit.Add(Convert.ToString(number % 16));
            }
            number /= 16;
        }
        for (int i = hexDigit.Count - 1; i >= 0; i--)
        {
            hexNumber += hexDigit[i];
        }
        Console.WriteLine(hexNumber);
    }
}