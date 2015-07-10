using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var dot = '.';
        var star = '*';

        
        Console.WriteLine("{0}{1}{0}",
                new string(dot, n / 2),
                new string(star, 1)
                );

        for (int i = 1; i <= (n / 2) -1; i+= 2)
        {
            
        }        
    }
}

