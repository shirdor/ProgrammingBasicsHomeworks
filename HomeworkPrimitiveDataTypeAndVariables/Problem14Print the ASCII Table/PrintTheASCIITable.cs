using System;

class PrintTheASCIITable
{
    static void Main()
    {
        for (char i = '\u0000'; i <= 255; i++)
        {
            Console.Write(i + " ");
        }

    }
}

