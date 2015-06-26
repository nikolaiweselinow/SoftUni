using System;

class NewHouse
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var roof = (n / 2) + 1;
        var star = '*';

        for (int i = 1; i <= n ; i+=2)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('-', (n - i) / 2),
                new string(star,i)
                );    
        }
        
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('|', 1),
                new string(star, (n - 2))
                );
        }
    }
}

