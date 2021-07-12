using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(91,22);
            Console.SetBufferSize(91,22);
            Point p1 = new Point(15, 3, '*');
            p1.draw();
            HorizontalLine upline = new HorizontalLine(0,89,0, '-');
            HorizontalLine downline = new HorizontalLine(0,89,19, '-');
            VerticalLine leftline = new VerticalLine(0,20, 0, '|');
            VerticalLine rightline = new VerticalLine(0,20,89, '|');
            upline.draw();
            downline.draw();
            leftline.draw();
            rightline.draw();
            Console.WriteLine('\n');
        }

    }
}
