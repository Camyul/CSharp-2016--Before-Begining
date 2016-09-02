using System;


class Program
{
    static void Main()
    {
        double coordinateX = Convert.ToDouble(Console.ReadLine());
        double coordinateY = double.Parse(Console.ReadLine());
        double radius = Math.Sqrt((Math.Pow(coordinateX, 2)) + (Math.Pow(coordinateY, 2)));
        if (radius <= 2) 
        {
            if (radius >= -2)
            {
                Console.WriteLine("yes {0:F2}", radius);
            }
        }
        else
        {
            Console.WriteLine("no {0:F2}", radius);
        }
    }
}
