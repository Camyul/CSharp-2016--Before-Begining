using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = i * 5;
        }
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}