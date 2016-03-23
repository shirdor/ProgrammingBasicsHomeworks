using System;

class FibonacciNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int c;
        Console.Write(a + ", " + b + ", " );
        for (int i = 0; i < number - 2; i++)
        {
            c = a;
            a = b;
            b = a + c;
            Console.Write(b+", ");
        }
        
    }   
}

