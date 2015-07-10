using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ConsoleGraphics
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal middle = n / 2;

        Console.WriteLine("{0}", new string('*', n * 2));
        Console.WriteLine("{0}", new string('*', n * 2));

        for (int i = 1; i <= n - 1; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('*', ((2 * n) - (n - 1)) / 2),
                new string(' ', n - 1)
                );
        }

        Console.WriteLine("{0}", new string('~', n * 2));
        Console.WriteLine("{0}", new string('~', n * 2));
    }
}
