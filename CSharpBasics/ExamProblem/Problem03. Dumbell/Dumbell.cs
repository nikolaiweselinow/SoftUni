using System;

class Dumbell
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //first row
        Console.WriteLine("{0}{1}{2}{1}{0}",
            new string('.', n / 2),
            new string('&', (n / 2) + 1),
            new string('.', n)
            );
        //rows between first and middle
        for (int i = 1, j = n / 2; i <= (n / 2) - 1; i++, j++)
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}",
                new string('.', (n / 2) - i),
                new string('*', j),
                new string('.', n)
                );
        }
        //middle row
        Console.WriteLine("&{0}&{1}&{0}&",
            new string('*', n - 2),
            new string('=', n)
            );
        //rows between middle and last
        for (int i = 1; i <= (n / 2) - 1; i++)
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}",
                new string('.', i),
                new string('*', n - (2 + i)),
                new string('.', n)
                );
        }
        //last row
        Console.WriteLine("{0}{1}{2}{1}{0}",
            new string('.', n / 2),
            new string('&', (n / 2) + 1),
            new string('.', n)
            );
    }
}

