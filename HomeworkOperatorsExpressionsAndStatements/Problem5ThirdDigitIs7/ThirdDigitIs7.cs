using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("enter number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine((number / 100) % 10 ==7);
    }
}

