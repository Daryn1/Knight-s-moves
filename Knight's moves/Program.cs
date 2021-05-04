using System;
using System.Drawing;
using System.Threading;
using Knight_s_moves;

namespace Knights_moves
{
    class Program
    {
        static void Main(string[] args)
        {
            var knight = new Knight(new Point(0, 0));
            var game = new ChessGame(knight, new RandomMoveTaker());
            var boardDrawer = new BoardDrawer();
            var numberOfMoves = 0;

            while (game.MoveKnight())
            {
                boardDrawer.Draw(game.board, knight.currentPosition);
                numberOfMoves++;
                Thread.Sleep(1000);
            }

            Console.WriteLine();
            Console.WriteLine($"Возможных ходов для коня больше нет. Конь походил {numberOfMoves} раз");
        }
    }
}
