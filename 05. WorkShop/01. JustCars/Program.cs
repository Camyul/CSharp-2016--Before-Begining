using System;
using System.Collections.Generic;
using System.Threading;

struct Object
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
    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.WriteLine(str);
    }
    static void Main()
    {
        int playerfieldWidth = 5;
        int livescount = 5;
        double speed = 100;
        double acceleration = 0.5;
        Console.BufferHeight = Console.WindowHeight = 30;
        Console.BufferWidth = Console.WindowWidth = 30;
        Object userCar = new Object();
        userCar.x = 2;
        userCar.y = Console.WindowHeight - 1;
        userCar.c = '@';
        userCar.color = ConsoleColor.Yellow;
        Random randomGenerator = new Random();
        List<Object> objects = new List<Object>();
        while (true)
        {
            speed += acceleration;
            if (speed > 500)
            {
                speed = 500;
            }
            bool hitted = false;
            //Move our car (key passed)
            int chanse = randomGenerator.Next(0, 100);
            if (chanse < 2)
            {
                Object bonusSpeed = new Object();
                bonusSpeed.c = '-';
                bonusSpeed.color = ConsoleColor.Cyan;
                bonusSpeed.x = randomGenerator.Next(0, playerfieldWidth);
                bonusSpeed.y = 0;
                objects.Add(bonusSpeed);
            }
            else if (chanse < 20)
            {
                Object bonusSpeed = new Object();
                bonusSpeed.c = '*';
                bonusSpeed.color = ConsoleColor.Cyan;
                bonusSpeed.x = randomGenerator.Next(0, playerfieldWidth);
                bonusSpeed.y = 0;
                objects.Add(bonusSpeed);
            }
            else
            {
                Object newCar = new Object();
                newCar.color = ConsoleColor.DarkGreen;
                newCar.x = randomGenerator.Next(0, playerfieldWidth);
                newCar.y = 0;
                newCar.c = '#';
                objects.Add(newCar);
            }
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                //while (Console.KeyAvailable)
                //{
                //    Console.ReadKey(true);
                //}
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
            List<Object> newList = new List<Object>();
            for (int i = 0; i < objects.Count; i++)
            {
                Object oldCar = objects[i];
                Object newObject = new Object();
                newObject.x = oldCar.x;
                newObject.y = oldCar.y + 1;
                newObject.c = oldCar.c;
                newObject.color = oldCar.color;
                if ((newObject.c == '-') && (newObject.y == userCar.y) && (newObject.x == userCar.x))
                {
                    livescount++;
                }
                if ((newObject.c == '*') && (newObject.y == userCar.y) && (newObject.x == userCar.x))
                {
                    speed -= 20;
                }
                if ((newObject.c == '#') && (newObject.y == userCar.y) && (newObject.x == userCar.x))
                {
                    livescount--;
                    hitted = true;
                    speed += 50;
                }
                if (newObject.y < Console.WindowHeight)
                {
                    newList.Add(newObject);
                }
                             
            }
            objects = newList;
            //Check if other cars hitting us
            //Clear the console
            Console.Clear();
            //Redraw Playfield
            foreach (Object car in objects)
            {
                PrintOnPosition(car.x, car.y, car.c, car.color);
            }
            if (hitted == true)
            {
                objects.Clear();
                PrintOnPosition(userCar.x, userCar.y, 'X', ConsoleColor.Red);
            }
            else
            {
                PrintOnPosition(userCar.x, userCar.y, userCar.c, userCar.color);
            }
            if (livescount < 0)
            {
                PrintStringOnPosition(8, 10, "GAME OVER!!!", ConsoleColor.Red);
                PrintStringOnPosition(8, 12, "Press [enter] to exit", ConsoleColor.Red);
                Console.ReadLine();
                Environment.Exit(0);
            }
            //Draw info
            PrintStringOnPosition(8,4,"Lives: "+livescount, ConsoleColor.White);
            PrintStringOnPosition(8,5,"Speed: "+speed, ConsoleColor.White);
            PrintStringOnPosition(8,6,"Acceleration: " + acceleration, ConsoleColor.White);
            //Slow Dawn Program
            Thread.Sleep((int)(600-speed));
        }
    }
}
