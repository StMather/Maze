using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Game
    {
        public void MainMenu()
        {
            int choice = 0;
            do
            {
                choice = 0;
                Console.WriteLine("1.Play Maze");
                Console.WriteLine("2.Quit");
                Int32.TryParse(Console.ReadLine(), out choice);//returns true or false
                //Add switch case
                switch (choice) {
                    case 1:
                        Maze mazeIn = new Maze();
                        MazeGame(mazeIn);
                    break;
                }
            }while (choice != 2);
        }
        public void MazeGame(Maze mazeIn)
        {
            while(true){

                mazeIn.DisplayMaze();
                //ask user for movment
                //pass moment to player to verify and action
                //if at exit Break 
            }
        }
    }
}
