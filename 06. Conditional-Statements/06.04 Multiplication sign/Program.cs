using System;


class Program
{
    static void Main()
    {
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double number3 = double.Parse(Console.ReadLine());
        if ((number1 == 0) ||  (number2 == 0) || (number3 == 0))
        {
            Console.WriteLine("0");
        }
        else if ((number1 < 0) || (number2 < 0) || (number3 < 0))
        {
            int count = 0;
            if (number1 < 0)
            {
                count++;
            }
            if (number2 < 0)
            {
                count++;
            }
            if (number3 < 0)
            {
                count++;
            }
            if (count % 2 == 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
        else
        {
            Console.WriteLine("+");
        }
    }
}