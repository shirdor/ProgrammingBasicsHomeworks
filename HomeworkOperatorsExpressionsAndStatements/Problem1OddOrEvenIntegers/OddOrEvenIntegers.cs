using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("enter number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(number % 2 == 1 || number % 2 == -1);
    }
}

