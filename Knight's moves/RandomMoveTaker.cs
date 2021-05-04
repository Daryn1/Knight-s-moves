using System;
using System.Collections.Generic;
using System.Text;

namespace Knight_s_moves
{
    class RandomMoveTaker : IBestMoveFinder
    {
        private Random random = new Random();

        public Move FindBestMove(bool[][] board, List<Move> validMoves)
        {
            var randomIndex = random.Next(0, validMoves.Count - 1);

            return validMoves[randomIndex];
        }
    }
}
