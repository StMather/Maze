using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Maze
    {
        int horizontalStart = 0;
        int verticalStart = 0;
        Room[,] myMaze;
        public Maze()
         {
            Room[,] newMaze = new Room[4, 4] {
            { new Room(false, true, false, true, false), new Room(false, true, false, true, false), new Room(false, true, false, true, false), new Room(false, true, false, true, false) },
            { new Room(false, true, false, true, false), new Room(false, true, false, true, false), new Room(false, true, false, true, false), new Room(false, true, false, true, false) },
            { new Room(false, true, false, true, false), new Room(false, true, false, true, false), new Room(false, true, false, true, false), new Room(false, true, false, true, false)},
            { new Room(false, true, false, true, false), new Room(false, true, false, true, false), new Room(false, true, false, true, false), new Room(false, true, false, true, false)}};
        }
    private void GenerateMaze()//Add a random maze generator or pick from list of pre made mazes
        {
            throw new NotImplementedException();
        }

        private bool IsSolveable()//check every path in the maze untill an exit is found(return true) or not(return false)
        {
            return false;
        }
        private void DisplayMaze()//walk trhough maze and display rooms in the maze
        {
            /*example room
             ***
             * |
             *-*
             *Room,romm,room,room 1st row
             *Room,romm,room,room second row
             */
            /*{
            { 1, 0, 0, 0 },
            { 1, 1, 0, 1 },
            { 0, 1, 0, 0 },
            { 1, 1, 1, 1 } }
            */
            int N = myMaze.Length;
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    myMaze[i,j].Display();
                }
            }

        }


    }
}
