using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
   public class Room
    {
        private bool door { get; set;}//True means door(open space)
        private bool exit { get; set; }
        private bool hasBeenExplored { get; set; } = false;

        public Room(bool doorIn)
        {
            door = doorIn;
        }
        public Room(bool doorIn, bool explored)
        {
            door = doorIn;
            hasBeenExplored = true;
        }
        public bool IsDoor()
        {
            return door;
        }
        public void ExploreRoom()
        {
            hasBeenExplored = true;
        }
        public bool IsExplored()
        {
            return hasBeenExplored;
        }
        public void SetDoor()
        {
            door = true;
        }
        public void SetWall()
        {
            door = false;
        }
        public bool IsExit()
        {
            return exit;
        }
        public void SetExit()
        {
            exit = true;
        }


    }
}
