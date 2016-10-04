using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNminusK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            if (i <= k)
            {
                factorialK *= i;
            }
        }
        for (int i = 1; i <= (n - k); i++)
        {
            factorialNminusK *= i;
        }
        //BigInteger combination = factorialN / (factorialK * factorialNminusK);
        Console.WriteLine(factorialN / (factorialK * factorialNminusK));
    }
}