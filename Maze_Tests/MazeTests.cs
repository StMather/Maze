using Microsoft.VisualStudio.TestTools.UnitTesting;
using MazeConsole;

namespace Maze_Tests
{
    [TestClass]
    public class MazeTests
    {
        [TestMethod]
        public void IsWalkable()
        {
            Maze mazeDefault = new Maze();
            bool expected = true;
            bool actual = mazeDefault.IsPositionWalkable(0,2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NotWalkable()
        {
            Maze mazeDefault = new Maze();
            bool expected = false;
            bool actual = mazeDefault.IsPositionWalkable(0, 6);

            Assert.AreEqual(expected, actual);
        }
    }
}
