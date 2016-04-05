﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimatingCharacterObjects
{
    class monsterClass
    {
        public int x, y, size, speed;
        image[] monster = new image[4];

        public monsterClass(int _x, int _y, int _size, int _speed, image[] _monster)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            monster = _monster;
        }
        public void move(playerClass mc, string direction)
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
