using System;
class Program
{
    static void Main()
    {
        int m = Convert.ToInt32(Console.ReadLine());
        string textLine = Console.ReadLine();
        char[] simbols = new char[textLine.Length];
        long result = 0;
        for (int i = 0; i < textLine.Length ; i++)
        {
            simbols[i] = Convert.ToChar(textLine.Substring(i, 1));
        }
        for (int i = 0; i < textLine.Length; i++)
        {
            if (simbols[i] == '@')
            {
                break;
            }
            else if ((int)simbols[i] > 47 && (int)simbols[i] < 58)
            {
                result *= (long)char.GetNumericValue(simbols[i]);
            }
            else if ((int)simbols[i] > 64 && (int)simbols[i] < 91)
            {
                result += (int)simbols[i] - 65;
            }
            else if ((int)simbols[i] > 96 && (int)simbols[i] < 123)
            {
                result += (int)simbols[i] - 97;
            }
            else
            {
                result = result % m;
            }
        }
        Console.WriteLine(result);
    }
}