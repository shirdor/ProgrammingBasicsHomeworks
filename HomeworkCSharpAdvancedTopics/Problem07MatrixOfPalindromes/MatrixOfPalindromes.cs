using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int row = int.Parse(input.Split()[0]);
            int col = int.Parse(input.Split()[1]);
            int width = row;
            int height = col;
            char letter = '\u0061';
            string[,] matrix = new string[row, col +  row - 1];
            for (int i = 0; i < width; i++)
            {
                for (int j = i; j < height; j++)
                {
                    matrix[i, j] = "" +
                        (char)(letter + i) +
                        (char)(letter + j) +
                        (char)(letter + i) + " ";
                    Console.Write(matrix[i, j]);
                }
                height++;
                Console.WriteLine();
            }
        }
    }
}

