using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Doodle_Jump
{
    internal class Platforms
    {
        //The atributes for the platforms
        public int x, y = 0;
        public int width = 60;
        public int height = 10;
        public Rectangle Platform;
        public int speed;
        Random randGen = new Random();

        public Platforms(int _x, int _y, int _speed)
        {
            x = _x;
            y = _y;
            speed = _speed;

            Platform = new Rectangle(x, y, width, height);
        }

        public void Move (int width, int height)
        {
            
            y += speed;
        }
        public bool Collison(Player p)
        {
            Rectangle platformRec = new Rectangle(x, y, width, height);
            Rectangle heroRec = new Rectangle(p.x, p.y, p.width, p.height);

            if (platformRec.IntersectsWith(heroRec))
            {
                return true;
            }
            return false;
        }
    }
}
