using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.Boat20December2014
{
    class Boat
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char star = '*';
            char dot = '.';
            int body = (n - 1) / 2;

            //Console.WriteLine("{0}{1}{2}",
            //    new string(dot, n - 1),
            //    new string(star, 1),
            //    new string(dot, n)
            //    );


            for (int i = 1; i <= (n / 2) + 3; i+= 2)
            {
                Console.WriteLine("{0}{1}{2}",
                        new string(dot, n - i),
                        new string(star, i),
                        new string(dot, n)
                    );                
            }
            //for (int i = (n / 2) + 1; i >= 1; i -= 2)
            //{
            //    Console.WriteLine("{0}{1}{2}",
            //            new string(dot, n - i),
            //            new string(star, i),
            //            new string(dot, n)
            //        );
            //}
            Console.WriteLine("{0}", new string(star, n * 2));
        }
    }
}
