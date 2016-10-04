using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialNplus1 = 1;
        BigInteger factorial2N = 1;
        for (int i = 1; i <= (2 * n); i++)
        {
            factorial2N *= i;
            if (i <= (n+1))
            {
                factorialNplus1 *= i;
                if (i <= n)
                {
                    factorialN *= i;
                }
            }
        }
        Console.WriteLine(factorial2N/(factorialN * factorialNplus1));
    }
}