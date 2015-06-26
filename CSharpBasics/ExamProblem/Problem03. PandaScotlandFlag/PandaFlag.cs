using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PandaFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char letter = 'A';
        char nextChar;
        for (int i = 0; i < 26; i++)
        {
            nextChar = (char)((int)letter + i);
            Console.WriteLine(nextChar);
        }
        
       
    }
}

