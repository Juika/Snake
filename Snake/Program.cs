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
            Console.SetBufferSize(120, 50);
            Horizontal_line horizontal_line_top = new Horizontal_line(0, 40, 0, '+');
            Horizontal_line horizontal_line_bot = new Horizontal_line(0, 40, 15, '+');

            Vertical_Line vertical_line_left = new Vertical_Line(0, 0, 15, '+');
            Vertical_Line vertical_line_right = new Vertical_Line(40, 0, 15, '+');
            vertical_line_left.Draw();
            vertical_line_right.Draw();

            horizontal_line_bot.Draw();
            horizontal_line_top.Draw();

            Console.ReadLine();
        }
    }
}
