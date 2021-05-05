using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Knight_s_moves.Algorithms;

namespace Knight_s_moves
{
    class ChessGame
    {
        public bool[][] board = new bool[8][];

        public Knight knight;

        private IBestMoveFinder bestMoveFinder;

        public ChessGame(Knight knight, IBestMoveFinder bestMoveFinder)
        {
            this.knight = knight;
            this.bestMoveFinder = bestMoveFinder;
            ResetBoard();
        }

        public void ResetBoard()
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
