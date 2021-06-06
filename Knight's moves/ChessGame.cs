using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Knight_s_moves.Algorithms;

namespace Knight_s_moves
{
    public class ChessGame
    {
        /// <summary>
        /// Игровая доска. true указывает клетку, на которую конь уже походил, false - на возможную для хода.
        /// </summary>
        public bool[][] Board;

        public IFigure Knight { get; set; }

        private IBestMoveFinder bestMoveFinder;

        public ChessGame(IFigure knight, IBestMoveFinder bestMoveFinder)
        {
            this.Knight = knight;
            this.bestMoveFinder = bestMoveFinder;
            ResetBoard();
        }

        public void ResetBoard()
        {
            Board = CleanBoardGenerator.CreateCleanBoardOfSize(Constants.BoardSize);
        }

        public bool MoveKnight()
        {
            var validMoves = Knight.GetValidMoves(Board);

            if (validMoves.Count == 0)
            {
                return false;
            }

            var bestMove = bestMoveFinder.FindBestMove(Board, validMoves);
            Board[bestMove.X][bestMove.Y] = true;
            Knight.CurrentPosition = new Point(bestMove.X, bestMove.Y);

            return true;
        }
    }
}
