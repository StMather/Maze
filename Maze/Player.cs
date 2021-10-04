using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Player
    {
        public int X { get; set; }
        public int Y { get; set; }
        private string PlayerMarker;
        private ConsoleColor PlayerColor;
        public Player(int initialX, int initialY)
        {

            X = initialX;
            Y = initialY;
            PlayerMarker = "o";
            PlayerColor = ConsoleColor.Red;

        }

        public void Draw()
        {
            Console.ForegroundColor = PlayerColor;
            Console.SetCursorPosition(X, Y);
            Console.Write(PlayerMarker);
        }

        public void HandlePlayerInput(Maze mazeIn)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            ConsoleKey Key = keyInfo.Key;
            switch (Key)
            {
                case ConsoleKey.UpArrow:
                    if (mazeIn.IsPositionWalkable(X, Y - 1))
                    {
                        Y -= 1;
                    }

                    break;
                case ConsoleKey.DownArrow:
                    if (mazeIn.IsPositionWalkable(X, Y + 1))
                    {
                        Y += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (mazeIn.IsPositionWalkable(X - 1, Y))
                    {
                        X -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (mazeIn.IsPositionWalkable(X + 1, Y))
                    {
                        X += 1;
                    }
                    break;
                default:
                    break;
            }
        }
        public int GetX()
        {
            return X;
        }
        public int GetY()
        {
            return Y;
        }
    }
}
