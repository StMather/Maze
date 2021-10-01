using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
   public class Room
    {
        private bool door { get; set;}
        private bool exit { get; set; }
        private bool hasBeenExplored { get; set; } = false;

        public Room(bool doorIn)
        {
            door = doorIn;
        }
        public void Display()
        {
            /*example room
             ***
             * |
             *-*
             end
             */

        }
        public bool IsDoor()
        {
            return door;
        }

    }
}
