using System;
using System.Drawing;
using System.Threading;
using Knight_s_moves.Algorithms;

namespace Knight_s_moves
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var startPosition = new Point(random.Next(0, 8), random.Next(0, 8));
            var knight = new Knight(startPosition);
            var consoleUi = new UserInterface();

            Console.ReadKey();

            IBestMoveFinder algorithm = new EvaluationFunction();
            var game = new ChessGame(knight, algorithm);
            consoleUi.PlayAndShow(game);
            Console.WriteLine("Это был алгоритм, использующий функцию оценки.");

            Console.ReadKey();

            algorithm = new RandomMoveTaker();
            knight.currentPosition = startPosition;
            game = new ChessGame(knight, algorithm);
            consoleUi.PlayAndShow(game);
            Console.WriteLine("Это был алгоритм, выбирающий случайный ход.");
        }
    }
}
