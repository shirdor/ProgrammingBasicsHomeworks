using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        for (int i = 2; i <= 14; i++)
        {
            if (i <= 10)
            {
                Console.WriteLine("{0} ♣ {0} ♦ {0} ♥ {0} ♠", i);
            }
            else
            {            
                for (int j = i; j <= 14; i++)
                {
                    switch (i)
                    {
                        case 11:
                            Console.WriteLine("{0} ♣ {0} ♦ {0} ♥ {0} ♠", 'J');
                            break;
                        case 12:
                            Console.WriteLine("{0} ♣ {0} ♦ {0} ♥ {0} ♠", 'Q');
                            break;
                        case 13:
                            Console.WriteLine("{0} ♣ {0} ♦ {0} ♥ {0} ♠", 'K');
                            break;
                        case 14:
                            Console.WriteLine("{0} ♣ {0} ♦ {0} ♥ {0} ♠", 'A');
                            break;
                        default:
                            break;
                    }
                    break;      
                }
            }
        }
    }
}

