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

            Point p1 = new Point(7, 2, '*');

            Point p2 = new Point(2,3,'#');
            
            p1.Draw();

            p2.Draw();

            List<int> numList = new List<int>();
            numList.Add(3);
            numList.Add(5);
            numList.Add(7);

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            int x = numList[0];

            Console.ReadLine();
        }
        static void Draw(Point p)
        {
            Console.SetCursorPosition(p.x, p.y);
            Console.Write(p.sym);
        }
    }
}
