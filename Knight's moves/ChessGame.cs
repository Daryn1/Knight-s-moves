using System;
using System.Collections.Generic;
using System.Text;

namespace Knight_s_moves
{
    class ChessGame
    {
        private bool[][] board = new bool[8][];

        private BoardDrawer boardDrawer = new BoardDrawer();

        private 

        public void Reset()
        {
            for (var i = 0; i < board.Length; ++i)
                board[i] = new bool[] { false, false, false, false, false, false, false, false };
        }

        public void Move()
        {
            
        }
    }
}
