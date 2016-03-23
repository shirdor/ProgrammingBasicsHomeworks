using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02PrimeChecker
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }
        static bool IsPrime(int n)
        {
            int counter = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (n % i == 0)
                {
                    counter++;
                }
            }
            bool result;
            if (counter == 2)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}

