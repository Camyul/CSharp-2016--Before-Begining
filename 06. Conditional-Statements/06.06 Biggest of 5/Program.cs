using System;
class Program
{
    static void Main()
    {
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double number3 = double.Parse(Console.ReadLine());
        double number4 = double.Parse(Console.ReadLine());
        double number5 = double.Parse(Console.ReadLine());
        double maxNumber = new double();
        if (number1 >= number2)
        {
            maxNumber = number1;
        }
        else
        {
            maxNumber = number2;
        }
        if (maxNumber <= number3)
        {
            maxNumber = number3;
        }
        if (maxNumber <= number4)
        {
            maxNumber = number4;
        }
        if (maxNumber <= number5)
        {
            maxNumber = number5;
        }
        Console.WriteLine(maxNumber);
    }
}