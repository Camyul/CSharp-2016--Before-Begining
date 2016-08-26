using System;

class Program
{
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (((number % 5) == 0) && ((number % 7) == 0))
        {
            Console.WriteLine("true {0}", number);
        }
        else
        {
            Console.WriteLine("false {0}", number);
        }
    }
}
