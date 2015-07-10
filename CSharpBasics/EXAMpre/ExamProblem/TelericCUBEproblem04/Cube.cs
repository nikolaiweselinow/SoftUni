using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelericCUBEproblem04
{
    class Cube
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}", new string(' ', n - 1), new string(':', n));
             
            Console.WriteLine("{0}:{1}::", 
                new string(' ', n - 2), 
                new string('/', n - 2)
                );

            for (int i = 1, j = n - 3; i <= n - 3; i++, j--)
            {
                Console.WriteLine("{0}:{1}:{2}:",
                    new string(' ', j),
                    new string('/', n - 2),
                    new string('X', i)
                    );                
            }

            Console.WriteLine("{0}{1}:",
                new string(':', n),
                new string('X', n - 2)
                );

            for (int i = 1, j = n - 3; i <= n - 3; i++, j--)
            {
                Console.WriteLine(":{0}:{1}:", 
                    new string(' ', n - 2),
                    new string('X', j)
                    );
            }

            Console.WriteLine(":{0}::", new string(' ', n - 2));

            //last line
            Console.WriteLine("{0}{1}",
                new string(':', n),
                new string(' ', n - 1)
                );
        }
    }
}
