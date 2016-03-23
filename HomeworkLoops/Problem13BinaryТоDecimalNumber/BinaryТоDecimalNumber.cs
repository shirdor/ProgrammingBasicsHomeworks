using System;

class BinaryТоDecimalNumber
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        ulong[] number = new ulong[binaryNumber.Length];
        double result = 0;
        int power = 0;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            number[i] = ulong.Parse(binaryNumber[i].ToString());
        }
        for (int j = number.Length -1; j >= 0; j--)
        {
            result += number[j] * Math.Pow(2, power);
            power++;
        }        
        Console.WriteLine(result);
    }
}

