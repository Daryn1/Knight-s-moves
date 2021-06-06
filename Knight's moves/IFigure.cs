using System.Collections.Generic;
using System.Drawing;

namespace Knight_s_moves
{
    public interface IFigure
    {
        Point CurrentPosition { get; set; }

        List<Move> GetValidMoves(bool[][] board);
    }
}