using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Knight_s_moves
{
    public class Knight : IFigure
    {
        public Point CurrentPosition { get; set; }

        public Knight(Point currentPosition)
        {
            this.CurrentPosition = currentPosition;
        }

        public List<Move> GetValidMoves(bool[][] board)
        {
            return GetPossibleMoves().Where(move => IsMoveValid(move, board)).ToList();
        }

        private bool IsMoveValid(Move move, bool[][] board)
        {
            return !board[move.X][move.Y];
        }

        private List<Move> GetPossibleMoves()
        {
            return GetAllMoves().Where(move => IsMovePossible(move)).ToList();
        }

        private bool IsMovePossible(Move move)
        {
            return move.X >= 0 && move.X < Constants.BoardSize && move.Y >= 0 && move.Y < Constants.BoardSize;
        }

        private List<Move> GetAllMoves()
        {
            var allMoves = new List<Move>()
            {
                new Move(CurrentPosition.X + 2, CurrentPosition.Y + 1),
                new Move(CurrentPosition.X - 2, CurrentPosition.Y + 1),
                new Move(CurrentPosition.X + 2, CurrentPosition.Y - 1),
                new Move(CurrentPosition.X - 2, CurrentPosition.Y - 1),
                new Move(CurrentPosition.X + 1, CurrentPosition.Y + 2),
                new Move(CurrentPosition.X - 1, CurrentPosition.Y + 2),
                new Move(CurrentPosition.X + 1, CurrentPosition.Y - 2),
                new Move(CurrentPosition.X - 1, CurrentPosition.Y - 2)
            };

            return allMoves;
        }
    }
}
