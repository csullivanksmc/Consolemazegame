using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlatformer
{
    public class PartyPosition
    {
        public void drawMe()
        {
            
            Console.SetCursorPosition(this.xPos, this.yPos);
            Console.Write("P");


        }

        public PartyPosition(int xpos, int ypos)
        {
            this.xPos = xpos;
            this.yPos = ypos;

        }
        public int xPos { get; set; }
        public int yPos { get; set; }
        
        public void MoveUp()
        {
            Console.SetCursorPosition(this.xPos, this.yPos);
            Console.Write(" ");
            this.yPos--;
        }

        public void MoveDown()
        {
            Console.SetCursorPosition(this.xPos, this.yPos);
            Console.Write(" ");
            this.yPos++;
        }

        public void MoveRight()
        {
            Console.SetCursorPosition(this.xPos, this.yPos);
            Console.Write(" ");
            this.xPos++;
        }

        public void MoveLeft()
        {
            Console.SetCursorPosition(this.xPos, this.yPos);
            Console.Write(" ");
            this.xPos--;
        }

    }
}
