using System;
using System.Collections.Generic;
using System.Text;
using Knight_s_moves;
using NUnit.Framework;
using Knight_s_moves.Algorithms;

namespace KnightsMoves.Tests
{
    [TestFixture]
    class EvaluationFunctionTests
    {
        [Test]
        public void FindBestMove_BoardIsCleanAndThereAre2ValidMoves_ReturnsMoveAfterWhichKnightCanMakeTheLeastNumberOfMoves()
        {
            var evaluationFunction = new EvaluationFunction();
            var cleanBoard = CleanBoardGenerator.CreateCleanBoardOfSize(Constants.BoardSize);
            var actualBestMove = new Move() {X = 0, Y = 0};
            // После хода в клетку (0, 0) у коня есть только 1 возможный ход, а после хода в клетку (4, 3) - 7
            var validMoves = new List<Move>
            {
                actualBestMove,
                new Move() {X = 4, Y = 3}
            };

            var result = evaluationFunction.FindBestMove(cleanBoard, validMoves);

            Assert.That(result, Is.EqualTo(actualBestMove));
        }
    }
}
