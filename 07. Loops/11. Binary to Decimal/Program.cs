using System;


class Program
{
    static void Main()
    {
        string binaryString = Console.ReadLine();
        string[] binariDigits = new string[binaryString.Length];
        long[] binariInt = new long[binaryString.Length];
        long longNumber = 0;
        for (int i = 0; i < binaryString.Length; i++)
        {
            binariDigits[i] = binaryString.Substring(i, 1);
        }
        for (int i = 0; i < binaryString.Length; i++)
        {
            binariInt[i] = long.Parse(binariDigits[i]);
        }
        for (int i = binaryString.Length - 1, j = 0; i >= 0; i--, j++)
        {
            if (binariInt[i] > 0)
            {
                longNumber += (long)Math.Pow(2, j);
            }
        }
        Console.WriteLine(longNumber);
    }
}