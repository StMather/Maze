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
        public void Display()
        {
            /*example room
             |||
             | |
             |||
             end
             */
           // if (hasBeenExplored)
            //{
                if (door)
                {
                    Console.Write(" ");
                    //for player location, need logic
                    //Console.Write("O");
                }
                else
                {
                    Console.Write("|");
                }
            //}
           /* else
            {
                Console.Write("#");
            }*/
        }
        public bool IsDoor()
        {
            return door;
        }
        public void ExploreRoom()
        {
            hasBeenExplored = true;
        }
        public void SetDoor()
        {
            door = true;
        }
        public void SetWall()
        {
            door = false;
        }

    }
}
