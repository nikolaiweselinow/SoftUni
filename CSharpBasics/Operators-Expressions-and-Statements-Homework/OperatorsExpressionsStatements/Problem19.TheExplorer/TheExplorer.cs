using System;
//Решението носи 100 точки в judge, отне ми около 40 мин. за да я реша (доста ме изнерви принтирането между средата и последния ред)
class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine("{0}*{0}", new string('-', n / 2)); //първи ред

        for (int i = 1, j = 1; i <= (n / 2) - 1; i++, j +=2)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('-', (n / 2) - i), 
                new string('-', j)
                );
        }

        Console.WriteLine("*{0}*", new string('-', n - 2)); // среда

        for (int i = 1; i <= (n / 2) - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", 
                new string('-', i), 
                new string('-', n - ((2 * i) + 2))
                );
        } 
   
        Console.WriteLine("{0}*{0}", new string('-', n / 2)); //последен ред
    }
}

