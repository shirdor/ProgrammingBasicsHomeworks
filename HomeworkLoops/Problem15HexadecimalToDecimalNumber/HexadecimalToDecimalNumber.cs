using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        string hexaDecimalNumber = Console.ReadLine();
        long[] number = new long[hexaDecimalNumber.Length];
        double result = 0;
        int power = 0;
        for (int i = 0; i < hexaDecimalNumber.Length; i++)
        {
            switch (hexaDecimalNumber[i])
            {
                case 'A':
                    number[i] = 10;
                    break;
                case 'B':
                    number[i] = 11;
                    break;
                case 'C':
                    number[i] = 12;
                    break;
                case 'D':
                    number[i] = 13;
                    break;
                case 'E':
                    number[i] = 14;
                    break;
                case 'F':
                    number[i] = 15;
                    break;
                default:
                    number[i] = long.Parse(hexaDecimalNumber[i].ToString());
                    break;
            }           
        }
        for (int j = number.Length - 1; j >= 0; j--)
        {
            result += number[j] * Math.Pow(16, power);
            power++;
        }
        Console.WriteLine(result);
    }
}

