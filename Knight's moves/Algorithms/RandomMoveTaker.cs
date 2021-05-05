using System;
using System.Collections.Generic;

namespace Knight_s_moves.Algorithms
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
