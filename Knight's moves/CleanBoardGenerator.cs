using System;
using System.Collections.Generic;
using System.Text;

namespace Knight_s_moves
{
    public static class CleanBoardGenerator
    {
        public static bool[][] CreateCleanBoardOfSize(int sizeOfBoard)
        {
            var board = new bool[sizeOfBoard][];

            for (var i = 0; i < board.Length; ++i)
            {
                var row = new bool[sizeOfBoard];

                for (var j = 0; j < row.Length; j++)
                {
                    row[j] = false;
                }

                board[i] = row;
            }

            return board;
        }
    }
}
