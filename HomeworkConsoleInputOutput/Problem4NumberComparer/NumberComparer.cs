using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b:");
        double b = double.Parse(Console.ReadLine());
        double greater = Math.Max(a, b);
        Console.WriteLine("greater is " + greater);
    }
}

