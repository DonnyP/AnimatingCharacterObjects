﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnimatingCharacterObjects
{
    class bulletClass
    {
        public int x, y, size, speed, direction;
        
        public bulletClass(int _x, int _y, int _size, int _speed, int _direction)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            direction = _direction;
        }
        public void move(bulletClass bc)
        {
            if (bc.direction == 2)
            {
                bc.x -= bc.speed;
            }
            else if (bc.direction == 3)
            {
                bc.x += bc.speed;
            }
            else if (bc.direction == 1)
            {
                bc.y -= bc.speed;
            }
            else //down
            {
                bc.y += bc.speed;
            }
        }
        public bool collision(bulletClass bc, monsterClass mc)
        {
            Rectangle bcRec = new Rectangle(bc.x, bc.y, bc.size, bc.size);
            Rectangle mcRec = new Rectangle(mc.x, mc.y, mc.size, mc.size);

            if (bcRec.IntersectsWith(mcRec))
            {
                return true;
            }
            else
                return false;
        }
    }
}
