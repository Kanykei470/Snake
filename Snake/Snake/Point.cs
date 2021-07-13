using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point() {}
        public Point(int _x,int _y,char _sym) 
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point (Point p) {
            x = p.x;
            y = p.y;
            sym  = p.sym;
        }
        public void move(int offset,Direction direction) {
           switch (direction)
            {
                case Direction.RIGHT:
                    this.x = x + offset;
                    break;
                case Direction.LEFT:
                    this.x = x - offset;
                    break;
                case Direction.DOWN:
                    this.y = y + offset;
                    break;
                case Direction.UP:
                    this.y = y - offset;
                    break;

            }
        }
        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}

