using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05.KnightPath
{
    class KnigthPath
    {
        static void Main(string[] args)
        {
            int[] board = new int[8];
            board[0] = 1;
            int horizontal = 0;
            int vertical = 0;
            while (true)
            {


                var command = Console.ReadLine();
                if (command == "stop")
                {
                    break;
                }

                var horizontalTemp = horizontal;
                var verticalTemp = vertical;

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
                        horizontal += 1;
                        vertical -= 2;
                        break;
                    case "down left":
                        horizontal += 1;
                        vertical += 2;
                        break;
                    case "up right":
                        horizontal -= 1;
                        vertical -= 2;
                        break;
                    case "down right":
                        horizontal -= 1;
                        vertical += 2;
                        break;

                    default:
                        break;
                }

                if (vertical > 7 || horizontal > 7 ||
                    vertical < 0 || horizontal < 0)
                {
                    vertical = verticalTemp;
                    horizontal = horizontalTemp;
                    continue;
                }

                board[vertical] ^= (1 << horizontal);                
            }
            var empty = true;

            foreach (var num in board)
            {
                if (num != 0)
                {
                    empty = false;
                    Console.WriteLine(num);
                }
            }

            if (empty)
            {
                Console.WriteLine("[Board is empty]");
            }
        }
    }
}



