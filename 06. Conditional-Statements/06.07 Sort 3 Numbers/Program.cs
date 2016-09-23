using System;
class Program
{

    static void Main()
    {
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double number3 = double.Parse(Console.ReadLine());
        if (number2 < number3)
        {
            number2 = number2 + number3;
            number3 = number2 - number3;
            number2 = number2 - number3;

        }
        if (number1 < number2)
        {
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            if (number2 < number3)
            {
                number2 = number2 + number3;
                number3 = number2 - number3;
                number2 = number2 - number3;
            }
        }
        Console.WriteLine("{0} {1} {2}", number1, number2, number3);
    }
}