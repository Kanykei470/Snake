using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(91,22);
            Console.SetBufferSize(91,22);
            Console.CursorVisible = false;
            
            HorizontalLine upline = new HorizontalLine(0,89,0, '-');
            HorizontalLine downline = new HorizontalLine(0,89,20, '-');
            VerticalLine leftline = new VerticalLine(0,20,0, '|');
            VerticalLine rightline = new VerticalLine(0,20,89, '|');
            upline.draw();
            downline.draw();
            leftline.draw();
            rightline.draw();
           
            Point p1 = new Point(4, 5, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.draw();
           //
           //Console.ReadKey();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);

        }

    }
}
