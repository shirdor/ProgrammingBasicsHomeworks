using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("enter number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("enter position");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("enter v");
        int v = int.Parse(Console.ReadLine());       
        int newNumber = number >> position;
        int mask = 1;
        int bitAtPosition = newNumber & mask;
        if (bitAtPosition == v)
        {
            Console.WriteLine(number);
        }
        else
        {
            v = 1;
            v = v << position;
            int result = number ^ v;
            Console.WriteLine(result);
        }
    }
}

