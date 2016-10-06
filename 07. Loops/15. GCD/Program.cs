using System;


class Program
{
    static void Main()
    {
        string twoNumbers = Console.ReadLine();
        string[] separatedNumbers = twoNumbers.Split(' ');
        int[] intNumbers = new int[separatedNumbers.Length];
        int firstNumber = new int();
        int secondNumber = new int();
        int rest = 2;
        for (int i = 0; i < separatedNumbers.Length; i++)
        {
            intNumbers[i] = Convert.ToInt32(separatedNumbers[i]);
        }
        firstNumber = Math.Max(intNumbers[0], intNumbers[1]);
        secondNumber = Math.Min(intNumbers[0], intNumbers[1]);
        do
        {
            rest = firstNumber % secondNumber;
            firstNumber = secondNumber;
            secondNumber = rest;
        }
        while (rest > 1);
        Console.WriteLine(secondNumber);
    }
}