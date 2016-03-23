using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Enter count: ");
        int count = int.Parse(Console.ReadLine());
        Console.Write("Enter start of the range: ");
        int startOFTheRange = int.Parse(Console.ReadLine());
        Console.Write("Enter finish of the range: ");
        int finishOfTheRange = int.Parse(Console.ReadLine());
        int min = Math.Min(startOFTheRange, finishOfTheRange);
        int max = Math.Max(startOFTheRange, finishOfTheRange);
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            Console.Write("{0} ", random.Next(min, max));

        }
    }
}

