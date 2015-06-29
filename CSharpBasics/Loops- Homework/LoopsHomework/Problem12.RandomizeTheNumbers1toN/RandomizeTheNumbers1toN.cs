using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RandomizeTheNumbers1toN
{
    static void Main()
    {
        Console.Title = "Problem 12.	* Randomize the Numbers 1…N";

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Random random = new Random();

        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", random.Next(1, n));
        }



        Console.WriteLine();
        //another way
        //with array
        int[] randomNumArr = new int[n];
        for (int i = 0; i < randomNumArr.Length; i++)
        {
            randomNumArr[i] = random.Next(1, n);
        }
        //print array
        foreach (var item in randomNumArr)
        {
            Console.Write("{0} ", item);
        }

    }
}

