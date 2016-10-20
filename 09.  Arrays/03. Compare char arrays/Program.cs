using System;
class Program
{
    static void Main()
    {

        char isEquals = new char();
        string firstSequence = Console.ReadLine();
        string secondSequence = Console.ReadLine();
        char[] firstChars = firstSequence.ToCharArray();
        char[] secondChars = secondSequence.ToCharArray();
        if (firstChars.Length == secondChars.Length)
        {
            //for (int i = 0; i < firstSequence.Length; i++)
            //{
            //    if (firstChars[i] != secondChars[i])
            //    {
            //        isEquals = false;
            //    }
            //}
            isEquals = '=';
        }
        else if (firstChars.Length > secondChars.Length)
        {
            isEquals = '>';
        }
        else
        {
            isEquals = '<';
        }
        Console.WriteLine(isEquals);
    }
}