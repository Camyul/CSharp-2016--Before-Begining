using System;

class Program
{
    static void Main()
    {
        double rectangleWidth = Convert.ToDouble(Console.ReadLine());
        double rectangleHeight = Convert.ToDouble(Console.ReadLine());
        double areaRectangle = rectangleHeight * rectangleWidth;
        double perimeterRectangle = (2 * rectangleWidth) + (2 * rectangleHeight);
        Console.WriteLine("{0:F2} {1:F2}", areaRectangle, perimeterRectangle);
    }
}
