using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char startLetter = char.Parse(Console.ReadLine());

        int toInc = 0;

        for (int i = 1; i <= 3; i++)
        {
            int charCount = i * 2 - 1;
            int dotCount = (7 - charCount) / 2;

            Console.Write(new string('.', dotCount));
            for (int j = 0; j < charCount; j++)
			{
                Console.Write((char)((startLetter + toInc)));
                if ((char)(startLetter + toInc) == 'G')
                {
                    toInc = -1;
                    startLetter = 'A';
                }                   
                toInc++;
			}
            Console.Write(new string('.', dotCount));
            Console.WriteLine();                        
        }
        for (int j = 0; j < 7; j++)
        {
            Console.Write((char)((startLetter + toInc)));
            if ((char)(startLetter + toInc) == 'G')
            {
                toInc = -1;
                startLetter = 'A';
            }
            toInc++;
        }
        Console.WriteLine();
        for (int i = 3; i >= 1; i--)
        {
            int charCount = 2 * i - 1;
            int dotCount = (7 - charCount) / 2;

            Console.Write(new string('.', dotCount));
            for (int j = 0; j < charCount; j++)
            {
                Console.Write((char)((startLetter + toInc)));
                if ((char)(startLetter + toInc) == 'G')
                {
                    toInc = -1;
                    startLetter = 'A';
                }
                toInc++;
            }
            Console.Write(new string('.', dotCount));
            Console.WriteLine();
        }
    }
}

