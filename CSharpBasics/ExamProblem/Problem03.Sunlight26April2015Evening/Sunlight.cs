using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.Sunlight26April2015Evening
{
    class Sunlight
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = n * 3;
            int height = n * 3;
            Console.WriteLine("{0}*{0}", new string('.', width / 2));

            for (int i = 1; i <= n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i), new string('.', (width / 2) - i - 1));
            }
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
            }
            Console.WriteLine("{0}", new string('*', width));
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
            }
            for (int i = n - 1; i >= 1; i--)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i), new string('.', (width / 2) - i - 1));
            }
            Console.WriteLine("{0}*{0}", new string('.', width / 2));
        }
    }
}
