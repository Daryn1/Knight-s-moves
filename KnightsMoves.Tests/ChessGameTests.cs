using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Knight_s_moves;
using Knight_s_moves.Algorithms;
using Moq;
using NUnit.Framework;

namespace KnightsMoves.Tests
{
    [TestFixture]
    class ChessGameTests
    {
        [Test]
        public void MoveKnight_NoValidMoves_ReturnsFalse()
        {
            var knightStub = new Mock<IFigure>();
            var emptyListOfValidMoves = new List<Move>();
            knightStub.Setup(knight => knight.GetValidMoves(It.IsAny<bool[][]>()))
                .Returns(emptyListOfValidMoves);
            var game = new ChessGame(knightStub.Object, null);

            var result = game.MoveKnight();

            knightStub.Verify(knight => knight.GetValidMoves(It.IsAny<bool[][]>()), Times.Once);
            Assert.That(result, Is.False);
        }

        [Test]
        public void MoveKnight_ThereAreValidMoves_ReturnsTrueChangesBoardAndKnightsPosition()
        {
            var knightStub = new Mock<IFigure>();
            var bestMoveFinderStub = new Mock<IBestMoveFinder>();
            var listOfValidMoves = new List<Move>
            {
                new Move(1, 2)
            };
            knightStub.Setup(knight => knight.GetValidMoves(It.IsAny<bool[][]>())).Returns(listOfValidMoves);
            knightStub.SetupSet(knight => knight.CurrentPosition = It.IsAny<Point>());
            var bestMove = listOfValidMoves[0];
            bestMoveFinderStub.Setup(moveFinder => moveFinder.FindBestMove(It.IsAny<bool[][]>(), listOfValidMoves))
                .Returns(bestMove);
            var game = new ChessGame(knightStub.Object, bestMoveFinderStub.Object);

            var result = game.MoveKnight();

            knightStub.Verify(knight => knight.GetValidMoves(It.IsAny<bool[][]>()), Times.Once);
            knightStub.VerifySet(knight => knight.CurrentPosition = new Point(bestMove.X, bestMove.Y), Times.Once);
            bestMoveFinderStub.Verify(moveFinder => moveFinder.FindBestMove(It.IsAny<bool[][]>(), listOfValidMoves), Times.Once);
            Assert.Multiple(() =>
            {
                Assert.That(game.Board[bestMove.X][bestMove.Y], Is.True); 
                Assert.That(result, Is.True);
            });
        }
    }
}
