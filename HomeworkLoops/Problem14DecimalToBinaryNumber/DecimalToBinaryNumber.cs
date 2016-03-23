using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        long deccimalNumber = long.Parse(Console.ReadLine());
        long newNumber = deccimalNumber;
        long extra = 0;
        string result = "";
        string binaryNumber = "";
        do
        {
            extra = newNumber % 2;
            binaryNumber += Convert.ToString(extra);
            newNumber /= 2;
        } while (newNumber != 0);
        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            result += binaryNumber[i].ToString();
        }
        Console.WriteLine(result);  
    }
}

