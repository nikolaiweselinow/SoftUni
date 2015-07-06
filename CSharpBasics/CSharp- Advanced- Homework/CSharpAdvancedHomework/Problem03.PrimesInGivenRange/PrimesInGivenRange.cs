using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimesInGivenRange
{
    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> numbers = new List<int>();

        for (int i = startNum; i <= endNum; i++)
        {
            bool isPrime = i > 1 ? true : false;

            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                }
            }

            if (isPrime)
            {
                numbers.Add(i);
            }
        }

        return numbers;
    }

    static void PrintList<T>(IEnumerable<T> primes)
    {
        if (primes.Any())
        {
            Console.WriteLine("Output:\n" + string.Join(", ", primes));
        }
        else
        {
            Console.WriteLine("(empty list)");
        }
    }

    static void Main()
    {
        Console.Title = "Problem 3.	Primes in Given Range";


        Console.Write("Enter start number (0 <= n): ");
        int startNum;
        bool startParse = int.TryParse(Console.ReadLine(), out startNum);

        Console.Write("Enter end number (0 <= n): ");
        int endNum;
        bool endParse = int.TryParse(Console.ReadLine(), out endNum);

        if (startParse && endParse && startNum >= 0 && endNum >= 0)
        {
            PrintList(FindPrimesInRange(startNum, endNum));
        }
        else
        {
            Console.WriteLine("invalid input");
        }
    }
}

