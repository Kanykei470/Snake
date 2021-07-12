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

            List<int> NumList = new List<int>();
            NumList.Add(4);
            NumList.Add(2);
            NumList.Add(8);
            Console.WriteLine('\n');
            foreach (int i in NumList)
                Console.WriteLine(i);
            NumList.RemoveAt(1);
            Console.WriteLine('\n');

            foreach (int i in NumList)
                Console.WriteLine(i);
            Console.ReadKey();

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

        }

    }
}
