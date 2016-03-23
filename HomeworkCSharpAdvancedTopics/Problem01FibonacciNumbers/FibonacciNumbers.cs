using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci number: {0}", Fib(number));
        }
        static int Fib(int n)
        {
            int firstFiboonaciiNumber = 0;
            int secondFiboonaciiNumber = 1;
            int fibN = 0;
            for (int i = 0; i <= n; i++)
            {               
                firstFiboonaciiNumber = secondFiboonaciiNumber;
                secondFiboonaciiNumber = fibN + firstFiboonaciiNumber;
                fibN = firstFiboonaciiNumber;
            }
            return fibN;
        }
    }
}
