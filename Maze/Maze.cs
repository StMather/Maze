using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Maze
    {
        int horizontalStart = 1;
        int verticalStart = 1;
        Room[,] myMaze;
        public Maze()
        {
            //    myMaze = new Room[4, 4] {
            //    { new Room(false, true, false, true, false), new Room(false, true, true, true, false), new Room(false, true, false, true, false), new Room(false, true, false, false, false) },
            //    { new Room(false, true, false, true, false), new Room(false, true, false, true, false), new Room(false, true, false, true, false), new Room(false, true, false, false, false) },
            //    { new Room(false, true, false, true, false), new Room(false, true, false, true, false), new Room(false, true, false, true, false), new Room(false, true, false, false, false)},
            //    { new Room(false, false, false, true, false), new Room(false, false, false, true, false), new Room(false, false, false, true, false), new Room(false, false, false, false, false)}};


            /*string[,] grid ={   { "|", "|", "|", "|"},
                                { "|", "", "|", "" },
                                { "|", "", "","" },
                                { "|", "|","|", "" } }*/
            myMaze = new Room[4, 4]{
                            { new Room(false), new Room(false), new Room(false),new Room(false)},
                            { new Room(false), new Room(true), new Room(false),new Room(false)},
                            { new Room(false), new Room(true), new Room(true),new Room(false)},
                            { new Room(false), new Room(false), new Room(false),new Room(false)}};
        }
        public Maze(int size)
        {
            Room[,] mazeBuild = new Room[size, size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int chanceOfDoor = rand.Next(1, 101);//do some randization 60-70%
                    if (chanceOfDoor <= 60 && i > 0 && i < size-1 && j > 0 && j < size-1)//i's and j's build exterior wall
                    {

                        mazeBuild[i, j] = new Room(true);//door
                    }
                    else
                    {
                        mazeBuild[i, j] = new Room(false);//wall
                    }

                }
            }
            myMaze = mazeBuild;
        }

        private bool IsSolveable()//check every path in the maze untill an exit is found(return true) or not(return false)
        {
            return false;
        }
        public void DisplayMaze()//walk trhough maze and display rooms in the maze
        {
            /*example room
             ||||  XXXX
             | ||  X XX
             |O |  XO X 
             ||||  XXXX
            */
            int N = myMaze.GetLength(0);
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    myMaze[i, j].Display();
                }
                Console.WriteLine();
            }

        }


    }
}
