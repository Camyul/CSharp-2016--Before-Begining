using System;

    class Program
    {
        static void Main()
        {
        bool isFemale = new bool();
        Console.Write("Are You Female(y/n): ");
        char yourGender = char.Parse(Console.ReadLine());
        if ((yourGender == 89) || (yourGender == 121))
        {
            isFemale = true;
        }
        Console.WriteLine("isFemale = {0}", isFemale);
        }
    }
