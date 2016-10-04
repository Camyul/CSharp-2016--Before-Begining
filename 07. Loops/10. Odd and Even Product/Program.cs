using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] line = Console.ReadLine().Split(' ');
        int[] numbers = new int[n];
        long productOdd = 1;
        long productEven = 1;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(line[i]);
        }
        for (int i = 1; i < n; i= i+2)
        {
            productEven *= numbers[i];
        }
        for (int i = 0; i < n; i=i+2)
        {
            productOdd *= numbers[i];
        }
        if (productEven == productOdd)
        {
            Console.WriteLine("yes {0}", productOdd);
        }
        else
        {
            Console.WriteLine("no {0} {1}", productOdd, productEven);
        }
    }
}