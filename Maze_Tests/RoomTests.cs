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
    public class RoomTests
    {
        [TestMethod]
        public void IsADoor()
        {
            Room testRoom = new Room(true);
            bool expected = true;

            bool actual = testRoom.IsDoor();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NotADoor()
        {
            Room testRoom = new Room(false);
            bool expected = false;

            bool actual = testRoom.IsDoor();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsExplored()
        {
            Room testRoom = new Room(false,true);
            bool expected = true;

            bool actual = testRoom.IsExplored();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NotExplored()
        {
            Room testRoom = new Room(false, false);
            bool expected = false;

            bool actual = testRoom.IsExplored();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsAExit()
        {
            Room testRoom = new Room(true);
            bool expected = true;
            testRoom.SetExit();

            bool actual = testRoom.IsExit();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NotAExit()
        {
            Room testRoom = new Room(true);
            bool expected = false;

            bool actual = testRoom.IsExit();

            Assert.AreEqual(expected, actual);
        }

    }
}
