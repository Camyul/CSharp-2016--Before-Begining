using System;
class Program
{
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;
        if (number < 2)
        {
            Console.WriteLine(!isPrime);
        }
        else
        {
            for (int i = 2; i <= number; i++)
            {
                if (((number % i) == 0) && (number > i))
                {
                    isPrime = false;
                }
            }
            Console.WriteLine(isPrime);
        }
    }
}