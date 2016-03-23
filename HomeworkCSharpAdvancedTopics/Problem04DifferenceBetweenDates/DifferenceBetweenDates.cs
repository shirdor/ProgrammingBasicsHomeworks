using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main()
        {
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            TimeSpan difference = secondDate - firstDate;
            Console.WriteLine(difference.Days);
        }
    }
}

