using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Knight_s_moves
{
    class Knight
    {
        private Cell currentPosition;

        private const int maximumPossibleMoves = 8;

        public Move GetMove(bool[][] board)
        {
            var validMoves = GetValidMoves(board);

        }

        public List<Move> GetValidMoves(bool[][] board)
        {
            return GetPossibleMoves().Where(move => IsMoveValid(move, board)).ToList();
        }

        public bool IsMoveValid(Move move, bool[][] board)
        {
            if (board[move.DestinationCell.X][])
            {
                
            }
        }

        public List<Move> GetPossibleMoves()
        {
            return GetAllMoves().Where(move => IsMovePossible(move)).ToList();
        }

        public bool IsMovePossible(Move move)
        {
            return move.DestinationCell.X >= 0 && move.DestinationCell.X <= 7 &&
                   move.DestinationCell.Y >= 0 && move.DestinationCell.Y <= 7;
        }

        private List<Move> GetAllMoves()
        {
            var allMoves = new List<Move>()
            {
                new Move()
                {
                    DestinationCell = new Cell()
                    {
                        X = currentPosition.X + 2,
                        Y = currentPosition.Y + 1
                    },
                    StartCell = currentPosition
                },
                new Move()
                {
                    DestinationCell = new Cell()
                    {
                        X = currentPosition.X - 2,
                        Y = currentPosition.Y + 1
                    },
                    StartCell = currentPosition
                },
                new Move()
                {
                    DestinationCell = new Cell()
                    {
                        X = currentPosition.X + 2,
                        Y = currentPosition.Y - 1
                    },
                    StartCell = currentPosition
                },
                new Move()
                {
                    DestinationCell = new Cell()
                    {
                        X = currentPosition.X - 2,
                        Y = currentPosition.Y - 1
                    },
                    StartCell = currentPosition
                },
                new Move()
                {
                    DestinationCell = new Cell()
                    {
                        X = currentPosition.X + 1,
                        Y = currentPosition.Y + 2
                    },
                    StartCell = currentPosition
                },
                new Move()
                {
                    DestinationCell = new Cell()
                    {
                        X = currentPosition.X - 1,
                        Y = currentPosition.Y + 2
                    },
                    StartCell = currentPosition
                },
                new Move()
                {
                    DestinationCell = new Cell()
                    {
                        X = currentPosition.X + 1,
                        Y = currentPosition.Y - 2
                    },
                    StartCell = currentPosition
                },
                new Move()
                {
                    DestinationCell = new Cell()
                    {
                        X = currentPosition.X - 1,
                        Y = currentPosition.Y - 2
                    },
                    StartCell = currentPosition
                }
            };

            return allMoves;
        }
    }
}
