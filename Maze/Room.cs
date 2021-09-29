using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
   public class Room
    {
         private bool northside { get; set; }
       private bool southside { get; set; }
        private bool westside { get; set; }
        private bool eastside { get; set; }
        private bool exit { get; set; }
        private bool hasBeenExplored { get; set; } = false;

        public Room(bool north, bool south, bool west, bool east, bool exitIn)
        {
            northside = north;
            southside = south;
            westside = west;
            eastside = east;
            exit = exitIn;
        }
        public void Display()
        {

        }

    }
}
