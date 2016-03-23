using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long deccimalNumber = long.Parse(Console.ReadLine());
        long newNumber = deccimalNumber;
        long extra = 0;
        string result = "";
        string newResult = "";
        string hexideimalNumber = "";
        do
        {
            extra = newNumber % 16;
            switch (extra)
            {
                case 10:
                    result += 'A';
                        break;
                case 11:
                    result += 'B';
                    break;
                case 12:
                    result += 'C';
                    break;
                case 13:
                    result += 'D';
                    break;
                case 14:
                    result += 'E';
                    break;
                case 15:
                    result += 'F';
                    break;
                default:
                    result += extra;
                    break;
            }     
            newNumber /= 16;
        } while (newNumber != 0);
        hexideimalNumber += result;
        for (int i = hexideimalNumber.Length - 1; i >= 0; i--)
        {
            newResult += hexideimalNumber[i].ToString();
        }
        Console.WriteLine(newResult);
    }
}

