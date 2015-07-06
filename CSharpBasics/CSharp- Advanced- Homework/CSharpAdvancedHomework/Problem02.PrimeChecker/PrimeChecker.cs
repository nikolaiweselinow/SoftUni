using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. 

class PrimeChecker
{
    static bool IsPrime(int number)
    {
        if (number == 0 || number == 1)
            return false;
        if (number == 2)
            return true;


        if (number % 2 == 0)  //Even number  
            return false;    

        for (int i = 3; i < number; i += 2)
        {
            if (number % i == 0) 
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Title = "Problem 2.	Prime Checker";

        Console.WriteLine(IsPrime(int.Parse(Console.ReadLine())));
    }
}

