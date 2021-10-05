using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MazeConsole;

namespace Maze_Tests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void GettingX()
        {
            Player testPlayer = new Player(0, 0);
            int expected = 0;
            int actual = testPlayer.GetX();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GettingY()
        {
            Player testPlayer = new Player(0, 0);
            int expected = 0;
            int actual = testPlayer.GetY();

            Assert.AreEqual(expected, actual);
        }
        
    }
}
