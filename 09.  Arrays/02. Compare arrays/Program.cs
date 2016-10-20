using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] firstNumbers = new int[n];
        int[] secondNumbers = new int[n];
        bool isEquals = true;
        for (int i = 0; i < n; i++)
        {
            firstNumbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            secondNumbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            if (firstNumbers[i] != secondNumbers[i])
            {
                isEquals = false;
            }
        }
        Console.WriteLine(isEquals);
    }
}