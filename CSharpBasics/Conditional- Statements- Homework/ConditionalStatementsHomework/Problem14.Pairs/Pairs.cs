using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Pairs
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] sumOfPair = new int[numbers.Length / 2];

        
        for (int i = 0, j = 0; i < numbers.Length; i +=2, j++)
        {
            sumOfPair[j] = numbers[i] + numbers[i + 1];                                                
        }

        int diff = 0;
        for (int i = 0; i < sumOfPair.Length - 1; i++)
        {
            if (Math.Abs(sumOfPair[i] - sumOfPair[i + 1]) > diff)
            {
                diff = Math.Abs(sumOfPair[i] - sumOfPair[i + 1]);
            }
        }
        
        if (diff == 0)
        {
            Console.WriteLine("Yes, value={0}", sumOfPair[0]);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", diff);
        } 

        
    }
}

