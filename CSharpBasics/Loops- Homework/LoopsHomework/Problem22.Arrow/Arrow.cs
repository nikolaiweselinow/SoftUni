using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dot = '.';
        char sharp = '#';
        int width = (n * 2) - 1;

        Console.WriteLine("{0}{1}{0}", 
            new string(dot, n / 2), 
            new string(sharp, n)
            );

        for (int i = 1; i <= n - 2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}",
            new string(dot, n / 2),
            new string(dot, n - 2)
            );
        }

        Console.WriteLine("{0}{1}{0}",
            new string(sharp, (n / 2) + 1),
            new string(dot, n - 2)
            );

        for (int i = 1; i <= n - 2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", 
                new string(dot, i),
                new string(dot, (width - 2) - (2 * i))
                );
        }

        Console.WriteLine("{0}#{0}", new string(dot, n - 1));
    }
}
