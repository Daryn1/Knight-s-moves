using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Knight_s_moves
{
    class UserInterface
    {
        public void PlayAndShow(ChessGame game)
        {
            var boardDrawer = new BoardDrawer();
            var numberOfMoves = 0;

            while (game.MoveKnight())
            {
                boardDrawer.Draw(game.board, game.knight.currentPosition);
                numberOfMoves++;
                Thread.Sleep(300);
            }

            Console.WriteLine();
            Console.WriteLine($"Возможных ходов для коня больше нет. Конь походил {numberOfMoves} раз");
        }
    }
}
