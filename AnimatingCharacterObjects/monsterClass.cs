using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnimatingCharacterObjects
{
    class monsterClass
    {
        public int x, y, size, speed;
        public Image[] monsterImages;

        public monsterClass(int _x, int _y, int _size, int _speed, Image[] _monsterImages)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            monsterImages = _monsterImages;
        }
        public void move(monsterClass mc, string direction)
        {
            if (direction == "left")
            {
                mc.x -= mc.speed;
            }
            else if (direction == "right")
            {
                mc.x += mc.speed;
            }
            else if (direction == "up")
            {
                mc.y -= mc.speed;
            }
            else  //down
            {
                mc.y += mc.speed;
            }
        }
    }
}
