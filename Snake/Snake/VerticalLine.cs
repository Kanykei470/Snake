using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList;
        public VerticalLine(int xUp,int yDown,int x,char sym) {
            pList = new List<Point>();
            for (int i = xUp; i < yDown; i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);
            }
        }
        public void draw()
        {
            foreach (Point p in pList)
            {
                p.draw();
            }
        }
    }
}
