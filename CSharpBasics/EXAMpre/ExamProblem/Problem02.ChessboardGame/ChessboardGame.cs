using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ChessboardGame
{
    static void Main()
    {
        int boardSize = int.Parse(Console.ReadLine());
        string inputString = Console.ReadLine();
        
        int cellsCount = boardSize * boardSize;
        string additionalString = "";

        if (cellsCount > inputString.Length)
        {
            additionalString = new string(' ', cellsCount - inputString.Length);            
        }        

        int blackTeamScore = 0;
        int whiteTeamScore = 0;

        inputString = inputString + additionalString;

        

        for (int i = 0; i < cellsCount; i++)
        {
            char currentChar = inputString[i]; //променлива която държи буквата в момента

            if (
                (currentChar >= 'a' && currentChar <= 'z') ||
                (currentChar >= 'A' && currentChar <= 'Z') ||
                (currentChar >= '0' && currentChar <= '9')
            )
            {
                if (i % 2 == 0) // ако полето е черно ...т.е четно
                {
                    if (currentChar >= 'A' && currentChar <= 'Z')
                    {
                        whiteTeamScore = whiteTeamScore + currentChar;                        
                    }
                    else
                    {
                        blackTeamScore = blackTeamScore + currentChar;  
                    }
                }
                else
                {
                    if (currentChar >= 'A' && currentChar <= 'Z')
                    {
                        blackTeamScore = blackTeamScore + currentChar;
                    }
                    else
                    {
                        whiteTeamScore = whiteTeamScore + currentChar;
                    }
                }
            }
        }

        if (blackTeamScore < whiteTeamScore)
        {
            Console.WriteLine("The winner is: white team");
            Console.WriteLine(whiteTeamScore - blackTeamScore);
        }
        else if (blackTeamScore > whiteTeamScore)
        {
            Console.WriteLine("The winner is: black team");
            Console.WriteLine(blackTeamScore - whiteTeamScore);   
        }
        else
        {
            Console.WriteLine("Equal result: {0}", whiteTeamScore);
        }        
    }
}

