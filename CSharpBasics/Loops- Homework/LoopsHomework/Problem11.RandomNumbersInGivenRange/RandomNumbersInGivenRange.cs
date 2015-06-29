using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Title = "Problem 11.	Random Numbers in Given Range";
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("min = ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("max = ");
        int max = int.Parse(Console.ReadLine());

        Random random = new Random();

        Console.Write("{0} random numbers in range [{1}...{2}]: ", n, min, max);
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", random.Next(min, max));
        }
        Console.WriteLine();
    }
}

