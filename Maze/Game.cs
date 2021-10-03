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
                Console.WriteLine("1.Play Default Maze");
                Console.WriteLine("2.Play Sized Maze");
                Console.WriteLine("3.Quit");
                Int32.TryParse(Console.ReadLine(), out choice);//returns true or false
                //Add switch case
                switch (choice) {
                    case 1:
                        Maze mazeDefault = new Maze();
                        MazeGame(mazeDefault);
                    break;
                    case 2://add user input
                        Console.WriteLine("Enter the size of your maze, exterior wall included");
                        Int32.TryParse(Console.ReadLine(), out choice);
                        if(choice < 0)
                        {
                            break;
                        }
                        Maze mazeSized =new Maze(choice);
                        MazeGame(mazeSized);
                        break;
                }
            }while (choice != 3);
        }
        public void MazeGame(Maze mazeIn)
        {
            while(true){

                mazeIn.DisplayMaze();
                //ask user for movment
                //pass moment to player to verify and action
                //if at exit Break 
                break;
            }
        }
    }
}
