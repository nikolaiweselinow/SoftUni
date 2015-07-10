using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Disk
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        int center = n / 2;


        for (int j = 0; j < n; j++)
        {
            for (int i = 0; i < n; i++)
            {
                double distance = Math.Sqrt(Math.Pow(center - i, 2) + Math.Pow(center - j, 2));
                if (distance <= r)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}

