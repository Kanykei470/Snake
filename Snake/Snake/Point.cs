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
        public Point(int x,int y,char sym) 
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
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
                case Direction.UP:
                    this.y = y - offset;
                    break;
                case Direction.DOWN:
                    this.y = y + offset;
                    break;
           }
        }
        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void clear()
        {
            sym = ' ';
            draw();
        }

        public bool IsHint(Point food)
        {
            return food.x == this.x && food.y == this.y;
        }
    }
}

