using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? firstNumber = null;
        double? secondNumber = null;
        Console.WriteLine(firstNumber + 1);
        Console.WriteLine(secondNumber + 2.5);
    }
}

