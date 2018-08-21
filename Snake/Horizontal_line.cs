using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Horizontal_line : Figure
    {
        public Horizontal_line(int xLeft, int xRight, int y, char sym)
        {
            Point_list = new List<Point>();
            for(int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                Point_list.Add(p);
            }
           
        }
    }
}
