using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

struct Car
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;
}
   
    
class Program
{
    static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.WriteLine(c);
    }
    static void Main()
    {
        int playerfieldWidth = 5;
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 30;
        Car userCar = new Car();
        userCar.x = 2;
        userCar.y = Console.WindowHeight - 1;
        userCar.c = '@';
        userCar.color = ConsoleColor.Yellow;
        Random randomGenerator = new Random();
        List<Car> cars = new List<Car>();
        while (true)
        {
            //Move our car (key passed)
            Car newCar = new Car();
            newCar.color = ConsoleColor.DarkGreen;
            newCar.x = randomGenerator.Next(0, playerfieldWidth);
            newCar.y = 0;
            newCar.c = '#';
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (userCar.x > 0)
                    {
                        userCar.x--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (userCar.x < (playerfieldWidth - 1))
                    {
                        userCar.x++;
                    }
                }
            }
                        
            //Move Cars
            //Check if other cars hitting us
            //Clear the console
            Console.Clear();
            //Redraw Playfield
            PrintOnPosition(userCar.x, userCar.y, userCar.c, userCar.color);

            //Draw info
            //Slow Daown Program
            Thread.Sleep(100);
        }
    }
}
