using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Vertical_Line : Figure
    {
        public Vertical_Line(int x, int yTop, int yBot, char sym)
        {
            Point_list = new List<Point>();
            for(int y = yTop; y <= yBot; y++)
            {
                Point p = new Point(x, y, sym);
                Point_list.Add(p);
            }

        }
        
    }
}
