using System;
using System.Collections.Generic;
using System.Text;

namespace Knight_s_moves
{
    interface IBestMoveFinder
    {
        public Move FindBestMove(bool[][] board, List<Move> validMoves);
    }
}
