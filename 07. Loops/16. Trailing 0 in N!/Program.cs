using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int count = 0;
        int i = 1;
        while (((int)Math.Pow(5, i)) <= number)
        {
            
            count += number / (int)(Math.Pow(5, i));
            i++;
        }
        Console.WriteLine(count);
    }
}