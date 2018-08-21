using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> Point_list;

        public void Draw()
        {
            foreach (Point p in Point_list)
            {
                p.Draw();
            }
        }
    }
}
