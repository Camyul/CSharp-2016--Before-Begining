using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int count = 1;
        int maxCount = 0; ;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine()); 
        }
        for (int i = 1; i < n; i++)
        {
            if (numbers[i] == numbers[i-1])
            {
                count++;
                
            }
            else
            {
                if (maxCount <= count)
                {
                    maxCount = count;
                }
                count = 1;
            }
        }
        Console.WriteLine(maxCount);
    }
}