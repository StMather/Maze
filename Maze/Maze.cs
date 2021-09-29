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
        bool[,] myMaze;
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
            myMaze = new bool[4,4]{  
                            { false,false,false,false},
                            { false,true,false,false},
                            { false,true,true,false},
                            { false,false,false,false}};
        }
    private void GenerateMaze()//Add a random maze generator or pick from list of pre made mazes
        {
            throw new NotImplementedException();
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
                    if(myMaze[i,j])
                    {
                        Console.Write(" ");
                        //for player location, need logic
                        //Console.Write("O");
                    }
                    else
                    {
                        Console.Write("|");
                    }
            
                }
                Console.WriteLine();
            }

        }


    }
}
