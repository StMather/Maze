using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MazeConsole
{
    public class Maze
    {
        
        public Room[,] myMaze;
        public Maze()//default maze
        {
             myMaze = new Room[7, 7]{
                             { new Room(true), new Room(false), new Room(false),new Room(false),new Room(false), new Room(false), new Room(false)},
                             { new Room(true), new Room(true), new Room(true),new Room(false), new Room(true), new Room(false), new Room(false)},
                             { new Room(true), new Room(true), new Room(false),new Room(false),new Room(true), new Room(true), new Room(true)},
                             { new Room(true), new Room(true), new Room(false),new Room(true),new Room(false), new Room(true), new Room(false)},
                             { new Room(true), new Room(true), new Room(true),new Room(true),new Room(true), new Room(true), new Room(false)},
                             { new Room(false), new Room(true), new Room(false),new Room(false),new Room(false), new Room(true), new Room(false)},
                             { new Room(false), new Room(false), new Room(false),new Room(false),new Room(false), new Room(false), new Room(false)}};
             myMaze[2, 6].SetExit();
        }
        public Maze(bool explored)//default maze explored
        {
            myMaze = new Room[15, 15]{
                             { new Room(true,explored), new Room(false, explored), new Room(false, explored),new Room(false, explored),new Room(true, explored), new Room(true, explored), new Room(true, explored),new Room(true,explored), new Room(false, explored), new Room(false, explored),new Room(false, explored),new Room(false, explored), new Room(false, explored), new Room(false, explored),new Room(false, explored)},
                             { new Room(true,explored), new Room(true,explored), new Room(true,explored),new Room(false, explored), new Room(true,explored), new Room(false, explored), new Room(false, explored),new Room(true,explored), new Room(true,explored), new Room(true,explored),new Room(true, explored), new Room(true,explored), new Room(true, explored), new Room(true, explored),new Room(false, explored)},
                             { new Room(true,explored), new Room(true,explored), new Room(false, explored),new Room(false, explored),new Room(true,explored), new Room(false,explored), new Room(true,explored),new Room(true,explored), new Room(false,explored), new Room(false, explored),new Room(false, explored),new Room(false,explored), new Room(false,explored), new Room(true,explored),new Room(false, explored)},
                             { new Room(true,explored), new Room(true,explored), new Room(false, explored),new Room(true,explored),new Room(false, explored), new Room(true,explored), new Room(false, explored),new Room(false,explored), new Room(true,explored), new Room(true, explored),new Room(true, explored),new Room(true,explored), new Room(true,explored), new Room(true,explored),new Room(false, explored)},
                             { new Room(true,explored), new Room(true,explored), new Room(true,explored),new Room(true,explored),new Room(true, explored), new Room(true,explored), new Room(true, explored),new Room(true,explored), new Room(true,explored), new Room(false, explored),new Room(false, explored),new Room(false,explored), new Room(false,explored), new Room(false,explored),new Room(false, explored)},
                             { new Room(false, explored), new Room(true,explored), new Room(false, explored),new Room(true, explored),new Room(false, explored), new Room(true,explored), new Room(false, explored),new Room(false,explored), new Room(true,explored), new Room(false, explored),new Room(false, explored),new Room(true,explored), new Room(true,explored), new Room(true,explored),new Room(true, explored)},
                             { new Room(false, explored), new Room(true, explored), new Room(false, explored),new Room(false, explored),new Room(false, explored), new Room(false, explored), new Room(false, explored),new Room(false,explored), new Room(true,explored), new Room(true, explored),new Room(true, explored),new Room(false,explored), new Room(true,explored), new Room(false,explored),new Room(true, explored)},
                             { new Room(true, explored), new Room(true, explored), new Room(true, explored),new Room(true, explored),new Room(true, explored), new Room(true, explored), new Room(false, explored),new Room(true,explored), new Room(true,explored), new Room(false, explored),new Room(true, explored),new Room(false,explored), new Room(true,explored), new Room(false,explored),new Room(true, explored)},
                            { new Room(false, explored), new Room(false, explored), new Room(false, explored),new Room(true, explored),new Room(false, explored), new Room(false, explored), new Room(false, explored),new Room(true,explored), new Room(true,explored), new Room(false, explored),new Room(true, explored),new Room(false,explored), new Room(false,explored), new Room(false,explored),new Room(true, explored)},
                            { new Room(true, explored), new Room(true, explored), new Room(true, explored),new Room(true, explored),new Room(false, explored), new Room(false, explored), new Room(false, explored),new Room(false,explored), new Room(true,explored), new Room(false, explored),new Room(true, explored),new Room(true,explored), new Room(true,explored), new Room(true,explored),new Room(true, explored)},
                            { new Room(true,explored), new Room(false, explored), new Room(true, explored),new Room(false, explored),new Room(true, explored), new Room(true, explored), new Room(true, explored),new Room(true,explored), new Room(false, explored), new Room(false, explored),new Room(false, explored),new Room(false, explored), new Room(false, explored), new Room(false, explored),new Room(false, explored)},
                             { new Room(true,explored), new Room(false,explored), new Room(true,explored),new Room(false, explored), new Room(true,explored), new Room(false, explored), new Room(false, explored),new Room(true,explored), new Room(true,explored), new Room(true,explored),new Room(true, explored), new Room(true,explored), new Room(false, explored), new Room(true, explored),new Room(true, explored)},
                             { new Room(true,explored), new Room(false,explored), new Room(false, explored),new Room(false, explored),new Room(true,explored), new Room(true,explored), new Room(true,explored),new Room(true,explored), new Room(true,explored), new Room(false, explored),new Room(false, explored),new Room(true,explored), new Room(false,explored), new Room(true,explored),new Room(false, explored)},
                             { new Room(true,explored), new Room(false,explored), new Room(false, explored),new Room(true,explored),new Room(false, explored), new Room(true,explored), new Room(false, explored),new Room(true,explored), new Room(true,explored), new Room(false, explored),new Room(false, explored),new Room(true,explored), new Room(true,explored), new Room(true,explored),new Room(false, explored)},
                             { new Room(true,explored), new Room(true,explored), new Room(true,explored),new Room(true,explored),new Room(true, explored), new Room(true,explored), new Room(false, explored),new Room(true,explored), new Room(true,explored), new Room(false, explored),new Room(false, explored),new Room(true,explored), new Room(false,explored), new Room(true,explored),new Room(false, explored)},
                             };
            myMaze[2, 6].SetExit();
        }

        public Maze(int size)
        {
            if(size <0)
            {
                return;
            }
            Room[,] mazeBuild = new Room[size, size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int chanceOfDoor = rand.Next(1, 101);
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
            /*example maze
             ||||  XXXX
             | ||  X XX
             |O |  XO X 
             ||||  XXXX
            */
            int N = myMaze.GetLength(0);
            for (int y = 0; y < N; y++)
            {
                for (int x = 0; x < N; x++)
                {
                    Console.SetCursorPosition(x, y);
                    string element = "$";
                    if (myMaze[y, x].IsExplored())
                    {
                        if (myMaze[y, x].IsDoor())
                        {
                            element = " ";


                            if (myMaze[y, x].IsExit())

                            {
                                element = "X";
                                ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                ForegroundColor = ConsoleColor.White;
                            }
                        }
                        else
                        {
                            element = "█";//█
                        }
                       
                    }
                    else
                    {
                        element = "#";
                    }
                        Console.Write(element);
                }
            }

        }
        public bool IsPositionWalkable(int x, int y)
        {
            int size = myMaze.GetLength(0);
            if (x < 0 || y < 0 || x >= size || y >= size)
            {
                return false;
            }
            myMaze[y, x].ExploreRoom();
            return myMaze[y,x].IsDoor();
        }


    }
}
