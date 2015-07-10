using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Diamond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        //first line
        Console.WriteLine("{0}*{0}", new string('-', n / 2));
        
        for (int i = 1, j = 1; i <= (n / 2) - 1; i++, j += 2)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('-', (n / 2) - i),
                new string('-', j)
                );
        }
        //middle
        Console.WriteLine("*{0}*", new string('-', n - 2));

        for (int i = 1, j = n / 2; i <= (n / 2) - 1; i++, j -= 2)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('-', i ),
                new string('-', n - (2 + (2 * i)))
                ); 
        }


        //last line
        Console.WriteLine("{0}*{0}", new string('-', n / 2));
    }
}

