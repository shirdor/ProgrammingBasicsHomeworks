using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("enter number");
        int number = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (number % i == 0)
            {
                counter++;
            }            
        }
        Console.WriteLine(counter == 2);
    }
}

