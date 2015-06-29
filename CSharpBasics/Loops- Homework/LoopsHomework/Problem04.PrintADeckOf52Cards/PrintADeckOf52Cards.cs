using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
 
class PrintADeckOf52Cards
{
    static void Main()
    {
        Console.Title = "Problem 4.	Print a Deck of 52 Cards";
        Console.ForegroundColor = ConsoleColor.White;
        for (int i = 2; i < 15; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                
                switch (i)
                {
                    case 11:
                        Console.Write("J");
                        break;
                    case 12:
                        Console.Write("Q");
                        break;
                    case 13:
                        Console.Write("K");
                        break;
                    case 14:
                        Console.Write("A");
                        break;
                    default:
                        Console.Write("{0}", i);
                        break;
                }
                switch (j)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("♣ ");
                        Console.ForegroundColor = ConsoleColor.White;                        
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("♦ ");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("♥ ");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("♠ ");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
 
                    default:
                        break;
                }
                
            }
            Console.WriteLine();
        }

        //another way with Arrays

        //string [] facesCards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        //string[] suitsCards = { "♣", "♦", "♥", "♠" };        

        //foreach (var face in facesCards)
        //{
        //    foreach (var suits in suitsCards)
        //    {
        //        Console.Write("{0, 3}{1} ", face, suits);
        //    }
        //    Console.WriteLine();
        //}       
      
    }    
}
            
           
        
        
    
