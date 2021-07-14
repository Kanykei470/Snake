using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidht;
        int mapHeight;
        char sym;
        Random rnd = new Random();

        public FoodCreator(int mapWidht, int mapHeight, char sym ) {
            this.mapHeight = mapHeight;
            this.mapWidht = mapWidht;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = rnd.Next(2, mapWidht - 2);
            int y = rnd.Next(2, mapHeight - 2);
            //if(x==)
            return new Point(x, y, sym);
        }
    }
}
