using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("enter number");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.Write(i + " ");
            for (int j = i + 1 ; j < number + i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}

