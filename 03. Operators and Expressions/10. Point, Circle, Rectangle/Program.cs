using System;

class Program
{
    static void Main()
    {
        double coordinateX = Convert.ToDouble(Console.ReadLine());
        double coordinateY = double.Parse(Console.ReadLine());
        string inCircle = "inside circle";
        string outCircle = "outside circle";
        string inRectangle = "inside rectangle";
        string outRectangle = "outside rectangle";
        double radius = Math.Sqrt((Math.Pow((coordinateX - 1), 2)) + (Math.Pow((coordinateY - 1), 2)));
        if (radius <= 1.5)
        {
            if (radius >= -1.5)
            {
                Console.Write("{0} ", inCircle);
            }
            else
            {
                Console.Write("{0} ", outCircle);
            }
        }
        else
        {
            Console.Write("{0} ", outCircle);
        }
        if ((coordinateX >= -1) && (coordinateX <= 5))
        {
            if ((coordinateY <= 1) && (coordinateY >= -1))
            {
                Console.WriteLine(inRectangle);
            }
            else
            {
                Console.WriteLine(outRectangle);
            }
        }
        else
        {
            Console.WriteLine(outRectangle);
        }
    }
}
