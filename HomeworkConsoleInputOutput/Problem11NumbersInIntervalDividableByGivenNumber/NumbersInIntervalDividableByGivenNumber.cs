using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.WriteLine("Enter start number");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter  number");
        int end = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = start; i <= end;  i++)
        {
            if (i % 5 == 0)
            {
                counter = counter +1;
                Console.Write(i + ", ");
            }
        }
        Console.WriteLine("counter = " + counter);              
    }
}

