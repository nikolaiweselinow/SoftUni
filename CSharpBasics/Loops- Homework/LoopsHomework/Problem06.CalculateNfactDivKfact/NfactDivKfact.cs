using System;

class NfactDivKfact
{
    static void Main()
    {
        Console.Title = "Problem 6.	Calculate N! / K!";

        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int nFactorial = 1;
        int kFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i <= k) kFactorial = kFactorial * i;

            nFactorial = nFactorial * i;
        }
        Console.WriteLine(nFactorial / kFactorial);
    }
}

