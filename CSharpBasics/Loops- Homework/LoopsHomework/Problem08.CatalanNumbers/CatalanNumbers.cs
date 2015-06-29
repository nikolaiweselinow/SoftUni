using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.Title = "Problem 8.	Catalan Numbers";

        double n = double.Parse(Console.ReadLine());

        double devisionFactorial = 1;
        double nFirstFactorial = 1;
        double nSecondFactorial = 1;

        for (int i = 1; i <= 2 * n; i++)
        {
            devisionFactorial *= i;

            if (i <= n + 1)
            {
                nFirstFactorial = nFirstFactorial *  i;
            }

            if (i <= n)
            {
                nSecondFactorial = nSecondFactorial * i;
            }
        }

        double sum = devisionFactorial / (nFirstFactorial * nSecondFactorial);

        Console.WriteLine("Catalan(n): {0}", sum);
    }   
}

