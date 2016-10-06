using System;


class Program
{
    static void Main()
    {
        string twoNumbers = Console.ReadLine();
        string[] separatedNumbers = twoNumbers.Split(' ');
        int[] intNumbers = new int[separatedNumbers.Length];
        for (int i = 0; i < separatedNumbers.Length; i++)
        {
            intNumbers[i] = Convert.ToInt32(separatedNumbers[i]);
        }
        Console.WriteLine(intNumbers[0]);
    }
}