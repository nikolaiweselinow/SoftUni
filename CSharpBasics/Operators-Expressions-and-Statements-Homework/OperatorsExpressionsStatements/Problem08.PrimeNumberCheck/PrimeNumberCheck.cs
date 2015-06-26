using System;
//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).
class PrimeNumberCheck
{
    static void Main()
    {
        Console.Title = "Problem 8. Prime Number Check";

        Console.Write("Enter a positive number( lesser or equal to 100 ):  ");
        int n = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (n <= 0 || n >= 100)
        {
            isPrime = false;
            Console.WriteLine("Invalid value!\nPlease try again.");
        }
        else if (n == 1)
        {
            isPrime = false;
            Console.WriteLine("The number is prime: {0}", isPrime);
        }
        else
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    Console.WriteLine("The number is prime: {0}", isPrime);
                    return;
                }
            }
            isPrime = true;
            Console.WriteLine("The number is prime: {0}", isPrime);
        }
    }
}