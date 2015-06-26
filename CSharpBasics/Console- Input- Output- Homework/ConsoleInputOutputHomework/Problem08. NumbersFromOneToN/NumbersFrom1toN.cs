using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumbersFrom1toN
{
    static void Main()
    {
        Console.Title = "Problem 8.	Numbers from 1 to n";

        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('=', 3));
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i.ToString().PadLeft(2));
        }
        Console.WriteLine(new string('=', 3));
    }
}

