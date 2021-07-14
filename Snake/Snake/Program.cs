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
            //Set console properties
            Console.SetWindowSize(91,22);   
            Console.SetBufferSize(91,22);
            Console.CursorVisible = false;

            //Create lines for frame 
            HorizontalLine upline = new HorizontalLine(0,89,0, '-');
            HorizontalLine downline = new HorizontalLine(0,89,20, '-');
            VerticalLine leftline = new VerticalLine(0,20,0, '|');
            VerticalLine rightline = new VerticalLine(0,20,89, '|');

            //Draw frame
            upline.draw();
            downline.draw();
            leftline.draw();
            rightline.draw();

            //Create lines and draw snake
            Point p1 = new Point(4, 5, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.draw();

            //Create random food 
            FoodCreator foodCreator = new FoodCreator(91,22, 'o');
            Point food = foodCreator.CreateFood();
            food.draw();

            while (true) {
             
                snake.Move();
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.handleKey(key.Key);
                }
                snake.Move();
                Thread.Sleep(100);

                if (snake.eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.draw();
                }
                else
                {
                    snake.Move();
                    Thread.Sleep(100);
                }

               
            }
        }

    }
}
