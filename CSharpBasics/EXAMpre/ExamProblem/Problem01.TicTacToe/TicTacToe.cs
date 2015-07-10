using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TicTacToe
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int valueFirstCell = int.Parse(Console.ReadLine());

        int position = x + 1; // 1, 2, 3
        if (y == 1)
        {
            position = x + 4;  // 4, 5, 6
        }
        else if (y == 2)
        {
            position = x + 7;  // 7, 8, 9
        }
    }
}

