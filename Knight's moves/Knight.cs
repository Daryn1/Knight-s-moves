using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Knight_s_moves
{
    class Knight
    {
        public Point currentPosition;

        public Knight(Point currentPosition)
        {
            this.currentPosition = currentPosition;
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
            return move.X >= 0 && move.X <= 7 && move.Y >= 0 && move.Y <= 7;
        }

        private List<Move> GetAllMoves()
        {
            var allMoves = new List<Move>()
            {
                new Move()
                {
                    X = currentPosition.X + 2,
                    Y = currentPosition.Y + 1
                },
                new Move()
                {
                    X = currentPosition.X - 2,
                    Y = currentPosition.Y + 1
                },
                new Move()
                {
                    X = currentPosition.X + 2,
                    Y = currentPosition.Y - 1
                },
                
                new Move()
                {
                    X = currentPosition.X - 2,
                    Y = currentPosition.Y - 1
                },
                new Move()
                {
                    X = currentPosition.X + 1,
                    Y = currentPosition.Y + 2
                },
                new Move()
                {
                    X = currentPosition.X - 1,
                    Y = currentPosition.Y + 2
                },
                new Move()
                {
                    X = currentPosition.X + 1,
                    Y = currentPosition.Y - 2
                },

                new Move()
                {
                    X = currentPosition.X - 1,
                    Y = currentPosition.Y - 2
                }
            };

            return allMoves;
        }
    }
}
