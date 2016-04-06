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
        Image[] monster = new Image[4];

        public monsterClass(int _x, int _y, int _size, int _speed, Image[] _monster)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            monster = _monster;
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
