using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.MagicWand
{
    class Program
    {
        static void Main(string[] args)
        {
            //width 3*N + 2

            int n = int.Parse(Console.ReadLine());
            int width = (3 * n) + 2;
            char star = '*';
            char dot = '.';

            //first row
            Console.WriteLine("{0}*{0}", new string(dot, width / 2));

            for (int i = 1, j = 1; i <= (n / 2) + 1; i++, j += 2)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string(dot, (width / 2) - i),
                    new string(dot, j)
                    );
            }

            Console.WriteLine("{0}{1}{0}",
                new string(star, n),
                new string(dot, n + 2)
                );

            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string(dot, i),
                    new string(dot, width - 2 - (2 * i))
                    );
            }

            for (int i = 1, j = 0; i <= n / 2; i++, j++)
            {
                Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}",
                    new string(dot, (n / 2) - i),
                    new string(dot, n / 2),
                    new string(dot, j),
                    new string(dot, n)
                    );
            }

            Console.WriteLine("{0}{1}*{2}*{1}{0}",
                new string(star, (n / 2) + 1),
                new string(dot, n / 2),
                new string(dot, n)
                );

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}*{0}*{0}", new string(dot, n));
            }

            Console.WriteLine("{0}{1}{0}", new string(dot, n), new string(star, n + 2));
        }
    }
}
