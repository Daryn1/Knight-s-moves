using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Knight_s_moves.Algorithms
{
    public class EvaluationFunction : IBestMoveFinder
    {
        public Move FindBestMove(bool[][] board, List<Move> validMoves)
        {
            var moveWithLowestScore = validMoves[0];
            moveWithLowestScore.Score = EvaluateMove(board, moveWithLowestScore);

            foreach (var validMove in validMoves)
            {
                var move = validMove;
                move.Score = EvaluateMove(board, move);

                if (move.Score < moveWithLowestScore.Score)
                {
                    moveWithLowestScore = move;
                }
            }

            return moveWithLowestScore;
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
