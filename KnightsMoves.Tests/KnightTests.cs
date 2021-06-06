using System.Drawing;
using Knight_s_moves;
using NUnit.Framework;

namespace KnightsMoves.Tests
{
    [TestFixture]
    public class KnightTests
    {
        [Test]
        public void GetValidMoves_KnightInMiddleOfBoardAndBoardIsClean_Returns8ValidMoves()
        {
            var knight = CreateKnightInMiddleOfBoard();
            var cleanBoard = CleanBoardGenerator.CreateCleanBoardOfSize(Constants.BoardSize);

            var validMoves = knight.GetValidMoves(cleanBoard);

            Assert.Multiple(() =>
            {
                Assert.That(validMoves.Count, Is.EqualTo(8));
                CollectionAssert.Contains(validMoves, new Move(knight.CurrentPosition.X + 2, knight.CurrentPosition.Y + 1));
                CollectionAssert.Contains(validMoves, new Move(knight.CurrentPosition.X + 2, knight.CurrentPosition.Y - 1));
                CollectionAssert.Contains(validMoves, new Move(knight.CurrentPosition.X - 2, knight.CurrentPosition.Y + 1));
                CollectionAssert.Contains(validMoves, new Move(knight.CurrentPosition.X - 2, knight.CurrentPosition.Y - 1));
                CollectionAssert.Contains(validMoves, new Move(knight.CurrentPosition.X + 1, knight.CurrentPosition.Y + 2));
                CollectionAssert.Contains(validMoves, new Move(knight.CurrentPosition.X + 1, knight.CurrentPosition.Y - 2));
                CollectionAssert.Contains(validMoves, new Move(knight.CurrentPosition.X - 1, knight.CurrentPosition.Y + 2));
                CollectionAssert.Contains(validMoves, new Move(knight.CurrentPosition.X - 1, knight.CurrentPosition.Y - 2));
            });
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(Constants.BoardSize - 1, 0)]
        [TestCase(0, Constants.BoardSize - 1)]
        [TestCase(Constants.BoardSize - 1, Constants.BoardSize - 1)]
        public void GetValidMoves_KnightInCornerOfBoardAndBoardIsClean_Returns2ValidMoves(int x, int y)
        {
            var knight = new Knight(new Point(x, y));
            var cleanBoard = CleanBoardGenerator.CreateCleanBoardOfSize(Constants.BoardSize);

            var validMoves = knight.GetValidMoves(cleanBoard);

            Assert.That(validMoves.Count, Is.EqualTo(2));
        }

        [Test]
        public void GetValidMoves_KnightInMiddleOfBoardAndBoardIsCompletelyFilled_ReturnsNoMoves()
        {
            var knight = CreateKnightInMiddleOfBoard();
            var filledBoard = CreateCompletelyFilledBoard();

            var validMoves = knight.GetValidMoves(filledBoard);

            Assert.IsEmpty(validMoves);
        }

        private Knight CreateKnightInMiddleOfBoard()
        {
            return new Knight(new Point(3, 3));
        }

        private bool[][] CreateCompletelyFilledBoard()
        {
            var board = new bool[Constants.BoardSize][];

            for (var i = 0; i < board.Length; ++i)
            {
                var row = new bool[Constants.BoardSize];

                for (var j = 0; j < row.Length; j++)
                {
                    row[j] = true;
                }

                board[i] = row;
            }

            return board;
        }
    }
}