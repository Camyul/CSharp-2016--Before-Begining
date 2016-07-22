using System;

    class Program
    {
        static void Main()
        {
        string firstWord = "Hello";
        string secondWord = "World";
        object objectSentence = firstWord + " " + secondWord;
        string stringSentence = objectSentence.ToString();
        Console.WriteLine(stringSentence);
        }
    }
