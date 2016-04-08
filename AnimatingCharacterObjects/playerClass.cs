using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnimatingCharacterObjects
{
    class playerClass
    {
        public int x, y, size, speed;
        public Image[] playerImages;

        public playerClass(int _x, int _y, int _size, int _speed, Image[] _playerImages)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            playerImages = _playerImages;
        }

        public void move(playerClass pc, string direction)
        {
            if (direction == "left")
            {
                pc.x -= pc.speed;
            }
            else if (direction == "right")
            {
                pc.x += pc.speed;
            }
            else if (direction == "up")
            {
                pc.y -= pc.speed;
            }
            else  //down
            {
                pc.y += pc.speed;
            }

        }
        public bool collision(playerClass pc, monsterClass mc)
        {
            Rectangle pcRec = new Rectangle(pc.x, pc.y, pc.size, pc.size);
            Rectangle mcRec = new Rectangle(mc.x, mc.y, mc.size, mc.size);

            if (pcRec.IntersectsWith(mcRec))
            {
                return true;
            }
            else
                return false;
        }
    }
}
