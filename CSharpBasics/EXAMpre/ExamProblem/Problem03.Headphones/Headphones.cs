using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Headphones
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char star = '*';
        char tire = '-';

        int width = (n * 2) + 1;

        //first line
        Console.WriteLine("{0}{1}{0}",
            new string(tire, n / 2),
            new string(star, width - (2 * (n / 2)))
            );

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string(tire, n / 2),
                new string(tire, n)
            );
        }

        for (int i = 1, j = 3; i <= (n / 2) - 1; i++, j+=2)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string(tire, (n / 2) - i),
                new string(star, j),
                new string(tire, n - (2 * i))
                );
        }

        Console.WriteLine("{0}-{0}",  new string(star, n));

        for (int i = 1, j = 3; i <= (n / 2) - 1; i++, j += 2)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string(tire, i),
                new string(star, n - (2 * i)),
                new string(tire, j)
                );
        }

        Console.WriteLine("{0}*{1}*{0}",
            new string(tire, n / 2),
            new string(tire, n)
            );
    }        
}

