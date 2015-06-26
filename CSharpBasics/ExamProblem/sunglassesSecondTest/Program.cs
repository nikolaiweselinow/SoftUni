﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sunglassesSecondTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int iterations = n - 2;

            Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));
            for (int i = 1; i <= iterations; i++)
            {
                if ( i == n / 2)
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', (n * 2) - 2), new string('|', n));        
                }
                else
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', (n * 2) - 2), new string(' ', n));    
                }
                
            }
            Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));

        }
    }
}
