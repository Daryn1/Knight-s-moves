using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Knight_s_moves.Algorithms
{
    class EvaluationFunction : IBestMoveFinder
    {
        public Move FindBestMove(bool[][] board, List<Move> validMoves)
        {
            var bestMove = validMoves[0];
            bestMove.Score = EvaluateMove(board, bestMove);

            foreach (var validMove in validMoves)
            {
                validMove.Score = EvaluateMove(board, validMove);

                if (validMove.Score < bestMove.Score)
                {
                    bestMove = validMove;
                }
            }

            return bestMove;
        }

        /// <summary>
        /// Возвращает число ходов, которые может сделать конь, после хода move.
        /// </summary>
        private int EvaluateMove(bool[][] board, Move move)
        {
            // Создаём коня, который уже выполнил ход, для оценки правильности этого хода.
            var knight = new Knight(new Point(move.X, move.Y));
            var validMoves = knight.GetValidMoves(board);

            return validMoves.Count;
        }
    }
}
