using System;


class Program
{
    static void Main()
    {
        string hexNumber = Console.ReadLine();
        string[] hexDigit = new string[hexNumber.Length];
        long[] intDigit = new long[hexNumber.Length];
        long longNumber = 0;
        for (int i = 0; i < hexNumber.Length; i++)
        {
            hexDigit[i] = hexNumber.Substring(i, 1);
        }
        for (int i = 0; i < hexNumber.Length; i++)
        {
            switch (hexDigit[i])
            {
                case "0": intDigit[i] = long.Parse(hexDigit[i]); break;
                case "1": intDigit[i] = long.Parse(hexDigit[i]);break;
                case "2": intDigit[i] = long.Parse(hexDigit[i]);break;
                case "3": intDigit[i] = long.Parse(hexDigit[i]);break;
                case "4": intDigit[i] = long.Parse(hexDigit[i]);break;
                case "5": intDigit[i] = long.Parse(hexDigit[i]);break;
                case "6": intDigit[i] = long.Parse(hexDigit[i]);break;
                case "7": intDigit[i] = long.Parse(hexDigit[i]);break;
                case "8": intDigit[i] = long.Parse(hexDigit[i]);break;
                case "9": intDigit[i] = long.Parse(hexDigit[i]);break;
                case "A": intDigit[i] = 10L;break;
                case "B": intDigit[i] = 11L;break;
                case "C": intDigit[i] = 12L;break;
                case "D": intDigit[i] = 13L;break;
                case "E": intDigit[i] = 14L;break;
                case "F": intDigit[i] = 15L;break;
                default:
                    break;
            }
        }
        for (int i = (hexNumber.Length - 1), j = 0; i >= 0; i--, j++)
        {
            if (intDigit[i] > 0)
            {
                longNumber += intDigit[i]*((long)(Math.Pow(16, j)));
            }
        }
        Console.WriteLine(Convert.ToString(longNumber));
    }
}