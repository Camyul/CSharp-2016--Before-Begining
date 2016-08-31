using System;


class Program
{
    static void Main()
    {
        int fourDigitNumber = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[4];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = fourDigitNumber % 10;
            fourDigitNumber = fourDigitNumber / 10;
        }
        Console.WriteLine(numbers[0] + numbers[1] + numbers[2] + numbers[3]);
        Console.WriteLine("{0}{1}{2}{3}", numbers[0], numbers[1], numbers[2], numbers[3]);
        Console.WriteLine("{0}{1}{2}{3}", numbers[0], numbers[3], numbers[2], numbers[1]);
        Console.WriteLine("{0}{1}{2}{3}", numbers[3], numbers[1], numbers[2], numbers[0]);
    }
}