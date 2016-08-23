using System;

class Program
{
    static void Main()
    {
        int? nullableInteger = null;
        double? nullableDouble = null;
        int? nullableInteger2 = 5;
        double? nullableDouble2 = 4.54;
        Console.WriteLine(nullableInteger + nullableInteger2);
        Console.WriteLine(nullableDouble + nullableDouble2);
        Console.WriteLine("{0},{1},{2},{3}", nullableInteger, nullableInteger2, nullableDouble, nullableDouble2);
    }
}
