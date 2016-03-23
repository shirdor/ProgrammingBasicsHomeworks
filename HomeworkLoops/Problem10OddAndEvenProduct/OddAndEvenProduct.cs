using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Enter number with space between them: ");
        string[] numbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int[] number = new int[numbers.Length];
        int oddProduct = 1;
        int evenProduct = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            number[i] = int.Parse(numbers[i]);
            if (i % 2 == 1)
            {
                evenProduct *= number[i];
            }
            else
            {
                oddProduct *= number[i];
            }
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes\nProduct = {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no\nOdd product = {0}\nEven product = {1}",oddProduct, evenProduct);
        }
    }    
}

