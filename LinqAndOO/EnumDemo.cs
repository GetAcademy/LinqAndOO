using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndOO
{
    class EnumDemo
    {
        static void Mainx(string[] args)
        {
            int col = 10;
            int row = 5;
            Direction direction = Direction.Right;
            while (true)
            {
                Console.Clear();
                Console.CursorLeft = col;
                Console.CursorTop = row;
                string symbol = "";
                if (direction == Direction.Right) symbol = ">";
                else if (direction == Direction.Left) symbol = "<";
                else if (direction == Direction.Down) symbol = "V";
                else if (direction == Direction.Up) symbol = "^";
                Console.Write(symbol);
                var consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.Key == ConsoleKey.RightArrow) direction = Direction.Right;
                else if (consoleKeyInfo.Key == ConsoleKey.LeftArrow) direction = Direction.Left;
                else if (consoleKeyInfo.Key == ConsoleKey.DownArrow) direction = Direction.Down;
                else if (consoleKeyInfo.Key == ConsoleKey.UpArrow) direction = Direction.Up;
                else
                {
                    if (direction == Direction.Right) col++;
                    else if (direction == Direction.Left) col--;
                    else if (direction == Direction.Down) row++;
                    else if (direction == Direction.Up) row--;
                }
            }
        }

        static void Main2(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int retning = 1;
            //if (retning == 1) retning = 2;
            Direction myDirection = Direction.Right;
            if (myDirection == Direction.Right) myDirection = Direction.Down;

            int directionInt = (int) myDirection;

            Direction d = (Direction) 4;

            var s = myDirection.ToString();

            Direction.TryParse("Down", true, out Direction d2);
        }


        static void Main3(string[] args)
        {
            /*
             * 1 betyr høyre
             * 2 betyr venstre
             * 3 betyr ned
             * 4 betyr opp
             */
            int col = 10;
            int row = 5;
            int direction = 1;
            while (true)
            {
                Console.Clear();
                Console.CursorLeft = col;
                Console.CursorTop = row;
                string symbol = "";
                if (direction == 1) symbol = ">";
                else if (direction == 2) symbol = "<";
                else if (direction == 3) symbol = "V";
                else if (direction == 4) symbol = "^";
                Console.Write(symbol);
                var consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.Key == ConsoleKey.RightArrow) direction = 1;
                else if (consoleKeyInfo.Key == ConsoleKey.LeftArrow) direction = 2;
                else if (consoleKeyInfo.Key == ConsoleKey.DownArrow) direction = 3;
                else if (consoleKeyInfo.Key == ConsoleKey.UpArrow) direction = 4;
                else
                {
                    if (direction == 1) col++;
                    else if (direction == 2) col--;
                    else if (direction == 3) row++;
                    else if (direction == 3) row--;
                }
            }
        }
    }
}
