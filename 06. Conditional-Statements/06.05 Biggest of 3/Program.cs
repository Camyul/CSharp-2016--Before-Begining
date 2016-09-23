using System;


class Program
{
    static void Main()
    {
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double number3 = double.Parse(Console.ReadLine());
        if (number1 > number2)
        {
            if (number1 > number3)
            {
                Console.WriteLine(number1);
            }
            else
            {
                Console.WriteLine(number3);
            }
        }
        else
        {
            if (number2 > number3)
            {
                Console.WriteLine(number2);
            }
            else
            {
                Console.WriteLine(number3);
            }
        }
    }
}