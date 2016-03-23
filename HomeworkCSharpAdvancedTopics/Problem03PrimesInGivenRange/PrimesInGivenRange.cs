using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int final = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(", ", FindPrimesInRange(start, final)));
        }
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            int counter = 0;
            List<int> result = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    result.Add(i);
                }
                counter = 0;
            }
            return result;
        }
    }
}
