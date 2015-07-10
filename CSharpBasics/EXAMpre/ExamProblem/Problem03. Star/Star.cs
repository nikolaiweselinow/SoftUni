using System;

class Star
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}", new string('.', n));

        for (int i = 1, j = 1; i <= (n / 2) - 1; i++, j += 2)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', n - i),
                new string('.', j)
                );
        }
        Console.WriteLine("{0}{1}{0}",
            new string('*', (n / 2) + 1),
            new string('.', n - 1)
            );

        for (int i = 1; i <= (n / 2) - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', i),
                new string('.', ((n * 2) + 1) - (2 * i) - 2)
                );
        }

        Console.WriteLine("{0}*{1}*{1}*{0}",
            new string('.', n / 2),
            new string('.', (n / 2) - 1)
            );

        for (int i = 1, j = 1; i <= ((n / 2) - 1); i++, j += 2)
        {
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}",
                new string('.', ((n / 2) - i)),
                new string('.', (n / 2) - 1),
                new string('.', j)
                );
        }

        Console.WriteLine("{0}{1}{0}",
            new string('*', ((n / 2) + 1)),
            new string('.', n - 1)
            );
    }
}

