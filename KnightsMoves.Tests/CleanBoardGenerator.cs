using System;
using System.Collections.Generic;
using System.Text;
using Knight_s_moves;
using NUnit.Framework;

namespace KnightsMoves.Tests
{
    [TestFixture]
    public class CleanBoardGeneratorTests
    {
        [Test]
        public void CreateCleanBoardOfSize_GivenSize_ReturnsBoardOfGivenSize()
        {
            var board = CleanBoardGenerator.CreateCleanBoardOfSize(Constants.BoardSize);
            var rowOfFalse = new[] {false, false, false, false, false, false, false, false};

            foreach (var row in board)
            {
                Assert.That(row, Is.EqualTo(rowOfFalse));
            }
        }
    }
}
