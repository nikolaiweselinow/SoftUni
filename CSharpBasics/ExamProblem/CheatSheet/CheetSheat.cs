using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheet
{
    class CheetSheat
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            long vNumber = int.Parse(Console.ReadLine());
            long hNumber = int.Parse(Console.ReadLine());

            for (long row = vNumber; row < vNumber + rows; row++)
            {
                for (long col = hNumber; col < hNumber + cols; col++)
                {
                    Console.Write(row * col);

                    if (col < hNumber + cols - 1)
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
