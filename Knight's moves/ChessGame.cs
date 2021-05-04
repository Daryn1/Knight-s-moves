using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Knight_s_moves
{
    class ChessGame
    {
        public bool[][] board = new bool[8][];

        private Knight knight;

        private IBestMoveFinder bestMoveFinder;

        public ChessGame(Knight knight, IBestMoveFinder bestMoveFinder)
        {
            this.knight = knight;
            this.bestMoveFinder = bestMoveFinder;
            Reset();
        }

        public void Reset()
        {
            for (var i = 0; i < board.Length; ++i)
                board[i] = new bool[] { false, false, false, false, false, false, false, false };
        }

        public bool MoveKnight()
        {
            var validMoves = knight.GetValidMoves(board);

            if (validMoves.Count == 0)
            {
                return false;
            }

            var bestMove = bestMoveFinder.FindBestMove(board, validMoves);
            board[bestMove.X][bestMove.Y] = true;
            knight.currentPosition.X = bestMove.X;
            knight.currentPosition.Y = bestMove.Y;

            return true;
        }
    }
}
