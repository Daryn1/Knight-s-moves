using System;
using System.Collections.Generic;
using System.Text;

namespace Knight_s_moves
{
    public struct Move
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Score { get; set; }

        public Move(int x, int y)
        {
            X = x;
            Y = y;
            Score = 0;
        }

        public bool Equals(Move other)
        {
            return X == other.X && Y == other.Y;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Move other))
            {
                return false;
            }

            return Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}
