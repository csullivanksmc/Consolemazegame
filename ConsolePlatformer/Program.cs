using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlatformer
{
    class Program
    {
        
        static void Main(string[] args)
        {
            PartyPosition Location = new PartyPosition(1, 1);

            string maze = @"+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+
|                       |                   |                       |           |
+---+   +---+   +---+---+   +---+   +---+---+   +---+   +---+---+   +   +---+   +
|       |   |   |           |   |           |       |   |   |       |       |   |
+   +---+   +   +   +---+---+   +---+---+   +   +---+   +   +   +---+---+---+   +
|       |       |   |                   |       |       |       |               |
+   +   +   +---+   +---+   +   +---+   +---+---+   +---+---+   +---+   +---+   +
|   |   |   |   |       |   |   |       |       |   |       |           |       |
+---+   +   +   +---+   +---+   +   +---+---+   +   +   +   +---+---+---+   +---+
|       |       |       |       |               |       |   |       |       |   |
+   +   +---+---+   +---+   +---+---+---+---+   +---+---+   +---+   +   +---+   +
|   |   |       |   |           |           |   |       |       |   |   |       |
+   +---+   +   +   +---+---+   +---+   +   +   +   +   +---+   +   +   +   +   +
|   |       |       |       |       |   |   |   |   |       |   |   |       |   |
+   +   +---+---+---+   +   +---+   +   +   +   +---+---+   +   +   +---+---+   +
|   |   |               |           |   |   |               |   |               |
+   +   +---+---+---+   +---+---+---+   +   +---+---+---+   +   +---+---+   +---+
|       |               |   |           |           |       |   |       |       |
+   +---+   +---+---+---+   +   +---+---+---+---+   +   +---+   +   +   +---+   +
|   |       |           |   |   |       |       |   |   |   |       |   |       |
+   +   +   +   +---+   +   +   +   +   +   +   +   +   +   +---+---+   +   +---+
|       |   |       |   |           |   |   |   |   |   |           |   |       |
+   +---+---+---+   +   +---+---+---+   +   +   +   +   +   +---+   +   +---+   +
|   |               |           |   |       |   |           |   |   |       |   |
+---+   +---+---+---+---+---+   +   +---+   +---+---+---+---+   +   +---+   +   +
|   |   |       |           |   |       |   |           |       |       |   |   |
+   +   +   +---+   +---+   +   +---+   +   +   +---+   +---+   +---+   +   +   +
|   |   |           |       |       |       |   |           |           |   |   |
+   +   +   +---+---+   +---+---+   +   +---+   +---+---+   +---+---+   +   +---+
|   |   |   |   |       |           |       |       |   |           |   |       |
+   +   +   +   +   +---+   +---+---+---+---+---+   +   +---+---+   +   +---+   +
|       |   |   |           |                       |               |       |   |
+---+---+   +   +---+---+---+---+   +   +---+---+---+   +---+---+---+---+   +   +
|       |       |               |   |       |       |           |           |   |
+   +   +---+   +---+---+   +   +   +---+   +   +   +---+---+   +---+---+---+   +
|   |       |       |       |   |       |   |   |   |       |           |       |
+   +   +---+---+   +   +---+   +   +---+   +---+   +   +   +---+---+   +   +---+
|   |           |   |   |       |   |       |       |   |           |   |       |
+   +---+   +---+   +   +   +---+---+   +---+   +---+   +---+---+   +   +---+   +
|       |               |               |                       |               |
+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+";

            Console.WriteLine(maze);

            Console.WriteLine(maze[166]);
            Console.WriteLine(maze[Location.xPos + ((Location.yPos) * 83)]);

            while (true)
            { 

                if (Console.KeyAvailable)
                { 

                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.UpArrow && maze[(Location.xPos + ((Location.yPos) * 83) - 83)].ToString() != "-" && maze[(Location.xPos + ((Location.yPos) * 83) - 83)].ToString() != "+" )
                    {
                        Location.MoveUp();
                        
                    }
                    else if (keyInfo.Key == ConsoleKey.DownArrow && maze[(Location.xPos + ((Location.yPos) * 83) + 83)].ToString() != "-" && maze[(Location.xPos + ((Location.yPos) * 83) + 83)].ToString() != "+")
                    {
                        Location.MoveDown();
                        
                    }
                    else if (keyInfo.Key == ConsoleKey.LeftArrow && maze[(Location.xPos + ((Location.yPos) * 83) - 1)].ToString() != "|" && maze[(Location.xPos + ((Location.yPos) * 83) - 1)].ToString() != "+")
                    {
                        Location.MoveLeft();
                        
                    }
                    else if (keyInfo.Key == ConsoleKey.RightArrow && maze[(Location.xPos+((Location.yPos)*83)+1)].ToString() != "|" && maze[(Location.xPos + ((Location.yPos) * 83) + 1)].ToString() != "+")
                    {
                        Location.MoveRight();
                        
                    }

                }

                Location.drawMe();
                Console.SetCursorPosition(Location.xPos, Location.yPos);
                
                
            }
        }
    }
}
