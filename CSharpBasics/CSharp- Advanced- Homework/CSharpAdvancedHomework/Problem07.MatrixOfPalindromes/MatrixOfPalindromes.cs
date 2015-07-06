using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixOfPalindromes
{
    static void Main()
    {
        Console.Title = "Problem 7.	Matrix of Palindromes";

        Console.Write("Height: ");
        int height = int.Parse(Console.ReadLine()); 

        Console.Write("Width: ");
        int width = int.Parse(Console.ReadLine()); 

        string[,] polindromes = new string[height, width];

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                polindromes[i, j] = "" + (char)('a' + i) + (char)('a' + i + j) + (char)('a' + i);
                Console.Write(polindromes[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}

