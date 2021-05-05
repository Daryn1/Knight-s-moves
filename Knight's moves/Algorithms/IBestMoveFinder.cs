using System.Collections.Generic;

namespace Knight_s_moves.Algorithms
{
    interface IBestMoveFinder
    {
        public Move FindBestMove(bool[][] board, List<Move> validMoves);
    }
}
