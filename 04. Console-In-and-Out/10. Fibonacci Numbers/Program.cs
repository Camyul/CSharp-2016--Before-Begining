using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long fibonacciOne = 0;
        long fibonacciTwo = 1;
        long fibonacciSum = 1;
        Console.Write(fibonacciOne);
        if (n >= 2)
        {
            Console.Write(", {0}", fibonacciTwo);
        }
        if (n > 2)
        {
            for (int i = 2; i < n; i++)
            {
                Console.Write(", {0}", fibonacciSum);
                fibonacciOne = fibonacciTwo;
                fibonacciTwo = fibonacciSum;
                fibonacciSum = fibonacciOne + fibonacciTwo;
            }
        }               
    }
}