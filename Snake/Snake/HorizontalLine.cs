﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine:Figure
    {
        public HorizontalLine(int xLeft,int yRight,int y,char sym) {
            pList = new List<Point>();
            for (int x = xLeft; x < yRight;  x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }
    }
}
