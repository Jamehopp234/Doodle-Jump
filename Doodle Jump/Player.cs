using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doodle_Jump
{
    public class Player
    {
        public int x, y;
        public int Xspeed = 6;
        public int Yspeed = 6;
        public int width = 30;
        public int height = 50;

        public Player(int _x, int _y)
        {
            x = _x;
            y = _y;

            

        }
        public void Move(string direction)
        {
          
            if (direction == "right")
            {
                x += Xspeed;
               
            }
            if (direction == "left")
            {
                x -= Xspeed;
               
            }
            if(direction == "")
            {
                Xspeed = 0;
            }
        }

        
    }
}
