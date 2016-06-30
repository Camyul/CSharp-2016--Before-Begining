using System;

    class Program
    {
        static void Main()
        {
        //Console.Write("When is your birthday(MM.DD.YYYY): ");
        DateTime myBirthday = DateTime.Parse(Console.ReadLine());
        DateTime yearNow = DateTime.Now;
        int yearsDiff = yearNow.Year - myBirthday.Year;
        if (yearNow.Month < myBirthday.Month)
        {
            yearsDiff--;

        }
        if (yearNow.Month == myBirthday.Month)
        {
            if (yearNow.Day < myBirthday.Day)
            {
                yearsDiff--;
            }
        }
        Console.WriteLine(yearsDiff);
        Console.WriteLine(yearsDiff + 10);
        }
    }
