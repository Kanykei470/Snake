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
            Point p1 = new Point(1, 3, '*');
            p1.draw();

            Point p2 = new Point(4, 5, '#');
            p2.draw();

            HorizontalLine hline = new HorizontalLine(0, 15,12, '*');
            hline.draw();
            Console.WriteLine('\n');
            VerticalLine vline = new VerticalLine(0,20, 45, '0');
            vline.draw();
            Console.WriteLine('\n');
        }

    }
}
