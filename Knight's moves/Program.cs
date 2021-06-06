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

            IBestMoveFinder algorithm = new EvaluationFunction();
            var game = new ChessGame(knight, algorithm);
            consoleUi.PlayAndShow(game);
            Console.WriteLine("Это был алгоритм, использующий функцию оценки.");
            Console.WriteLine("Нажмите на любую клавишу 2 раза, чтобы запустить следующий алгоритм.");

            Console.ReadKey();
            Console.ReadKey();

            algorithm = new RandomMoveTaker();
            knight.CurrentPosition = startPosition;
            game = new ChessGame(knight, algorithm);
            consoleUi.PlayAndShow(game);
            Console.WriteLine("Это был алгоритм, выбирающий случайный ход.");
        }
    }
}
