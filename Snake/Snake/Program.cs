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

            //Create frame
            Walls walls = new Walls(91, 22);
            walls.Draw();

            //Create lines and draw snake
            Point p1 = new Point(4, 5, '*');
            Snake snake = new Snake(p1, 6, Direction.RIGHT);
            snake.draw();
           

            //Create random food 
            FoodCreator foodCreator = new FoodCreator(91,22, 'o');
            Point food = foodCreator.CreateFood();
            food.draw();

            //Creation of movement
            while (true) {
                int speed = 150;
                if (walls.IsHit(snake) || snake.IsHitTail())
                    break;
                if (snake.eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(speed);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.handleKey(key.Key);
                }
                if (snake.eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.draw();
                }
                else
                {
                    snake.Move();
                    Thread.Sleep(speed);
                }
                if (snake.score <= 2) { speed = 100;}
                if (snake.score <= 5) { speed = 50; }
                if (snake.score <= 7) { speed = 25; }
                Console.SetCursorPosition(0,21);
                Console.Write($"Score:{snake.score}");

            }
            WriteGameOver(snake);
            Console.ReadKey();
        }
       
        static void WriteGameOver(Snake snake)
        {
            int xOffset = 30;
            int yOffset = 6;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("===========================", xOffset, yOffset++);
            WriteText("        GAME OVER          ", xOffset, yOffset++);
            WriteText("===========================", xOffset, yOffset++);
            WriteText($"       YOUR SCORE:{snake.score}", xOffset, yOffset++);
            WriteText("===========================", xOffset, yOffset++);
        }

        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}
