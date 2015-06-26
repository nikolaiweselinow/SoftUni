using System;

class House
{
    static void Main(string[] args)
    {
        //Console.Title = "Problem 15.	* – House";

        int n = int.Parse(Console.ReadLine());
        char star = '*';
        char dot = '.';

        //First row
        Console.WriteLine("{0}{1}{0}",
            new string(dot, n / 2),
            new string(star, 1)
            );

        //Rows between first row and middle row
        for (int i = 1, j = 1; i <= (n / 2) - 1; i++, j+=2)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string(dot, (n / 2) - i),
                new string(dot, j)
                );
        }

        //Middle row
        Console.WriteLine(new string(star, n));

        //Rows between middle row and last row

        for (int i = 1; i <= (n / 2) - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string(dot, n / 4),
                new string(dot, n - (2 * (n / 4)) - 2)
                );
        }

        //Last row
        Console.WriteLine("{0}{1}{0}",
            new string(dot, n / 4),
            new string(star, n - 2 * (n / 4))
            );
    }
}