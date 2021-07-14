using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake:Figure
    {
         Direction  direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.move(i, direction);
                pList.Add(p);
            }
        }

        public void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = getNextPoint();
            pList.Add(head);
            tail.clear();
            head.draw();
           
        }

        public  Point getNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.move(1, direction);
            return nextPoint;
        }

        public void handleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.RightArrow:
                    direction = Direction.RIGHT;
                    break;
                case ConsoleKey.LeftArrow:
                    direction = Direction.LEFT;
                    break;
                case ConsoleKey.UpArrow:
                    direction = Direction.UP;
                    break;
                case ConsoleKey.DownArrow:
                    direction = Direction.DOWN;
                    break;
            }
        }

        public bool eat(Point food)
        {
            Point head = getNextPoint();
            if (head.IsHint(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                this.draw();
                return true;
            }
            else
                return false;
        }
    }
}
