using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MazeConsole
{
    class Game
    {
        public void MainMenu()
        {

            Title = "welcome to the Maze!";
            CursorVisible = false;
            int choice = 0;
            do
            {
                choice = 0;
                Console.WriteLine("1.Play Default Maze");
                Console.WriteLine("2.Play Explored Maze");
                Console.WriteLine("3.Quit");
                Int32.TryParse(Console.ReadLine(), out choice);//returns true or false
                //Add switch case
                switch (choice) {
                    case 1:
                        Maze mazeDefault = new Maze();
                        MazeGame(mazeDefault);
                    break;
                    /*
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
                    */
                    case 2:
                        bool explored = true;
                        Maze mazeExplored = new Maze(explored);
                        MazeGame(mazeExplored);
                        break;
                }
            }while (choice != 3);
        }
        public void MazeGame(Maze mazeIn)
        {
            Player myPlayer = new Player(0, 2);
            while (true){

                // Draw everything
                DrawFrame();
                mazeIn.DisplayMaze();
                myPlayer.Draw();
                // Check for player input from the keyboard and move the player
                myPlayer.HandlePlayerInput(mazeIn);
                //check if the player has reached the exit and end the game 
                //string elementAtplayerPos = mazeIn.GetElementAt(X,Y);
                int myX = myPlayer.GetX();
                int myY = myPlayer.GetY();
                if(mazeIn.myMaze[myY, myX].IsExit())
                {
                    break;
                }
                //allows the console to render display.
                System.Threading.Thread.Sleep(20);
            }
            Clear();
        }
        private void DrawFrame()
        {
            Clear();
        }
    }
}
