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
            Point p1 = new Point(1, 2, '*');
            Point p2 = new Point(2, 3, '#');
            Point p3 = new Point(3, 4, '/');
            Point p4 = new Point(4, 5, '+');
            
            //p1.Draw();
            //p2.Draw();

            /*List<int> numList = new List<int>();
            numList.Add(3);
            numList.Add(5);
            numList.Add(7);

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }*/

            //int x = numList[0];

            List<Point> Point_list = new List<Point>();

            Point_list.Add(p1);
            Point_list.Add(p2);
            Point_list.Add(p3);
            Point_list.Add(p4);

            foreach(Point p in Point_list)
            {
                p.Draw();
            }

            Console.ReadLine();
        }
    }
}
