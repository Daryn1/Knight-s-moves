using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Knight_s_moves
{
    class BoardDrawer
    {
        public void Draw(bool[][] board, Point knightPosition)
        {
            Console.Clear();

            for (var y = 0; y < board.Length; y++)
            {
                for (var x = 0; x < board.Length; x++)
                {
                    if (knightPosition.X == x && knightPosition.Y == y)
                    {
                        Console.Write(2);
                    }
                    else
                    { 
                        Console.Write(board[x][y] ? 1 : 0);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
