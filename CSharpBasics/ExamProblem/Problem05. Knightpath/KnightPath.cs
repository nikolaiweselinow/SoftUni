using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05.Knightpath
{
    class KnightPath
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int[] board = new int[8];
            board[0] = 1;
            int horizontal = 0;
            int vertical = 0;

            while (command != "stop")
            {
                command = Console.ReadLine();

                switch (command)
                {
                    case "left up":
                        horizontal += 2;
                        vertical -= 1;
                        break;
                    case "left down":
                        horizontal += 2;
                        vertical += 1;
                        break;
                    case "right up":
                        horizontal -= 2;
                        vertical -= 1;
                        break;
                    case "right down":
                        horizontal -= 2;
                        vertical += 1;
                        break;
                    case "up left":
                        vertical -= 2;
                        horizontal += 1;
                        break;
                    case "down left":
                        vertical += 2;
                        horizontal += 1;
                        break;
                    case "up right":
                        vertical -= 2;
                        horizontal -= 1;
                        break;
                    case "down right":
                        vertical += 2;
                        horizontal -= 1;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
