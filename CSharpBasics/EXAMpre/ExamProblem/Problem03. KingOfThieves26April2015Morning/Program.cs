using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('-', n / 2), new string(symbol, 1));

        for (int i = 1; i <= (n / 2) - 1; i++)
        {
            Console.WriteLine("{0}{1}{0}", 
                    new string('-', (n / 2) - i),
                    new string(symbol, n - 2 * ((n / 2) - i))
                    );
        }
        Console.WriteLine("{0}", new string(symbol, n));

        for (int i = (n / 2) - 1; i >= 1; i--)
        {
            Console.WriteLine("{0}{1}{0}",
                    new string('-', (n / 2) - i),
                    new string(symbol, n - 2 * ((n / 2) - i))
                    );
        }
        Console.WriteLine("{0}{1}{0}", new string('-', n / 2), new string(symbol, 1));
    }
}

