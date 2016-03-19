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
            /*Point p1 = new Point(1, 3, '*');
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            p1.draw();
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';
            draw(x1, y1, sym1);*/
            /*Point p2 = new Point(4, 5, '#');
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            p2.draw();
            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';
            draw(x2, y2, sym2);
            List<int> numlist = new List<int>();
            numlist.Add(0);
            numlist.Add(1);
            numlist.Add(2);
            int x = numlist[0];
            int y = numlist[1];
            int z = numlist[2];
            foreach(int i in numlist)
            {
                Console.WriteLine(i);
            }
            numlist.RemoveAt(0);
            List<Point> plist = new List<Point>();
            plist.Add(p1);
            plist.Add(p2);*/
            //Отрисовка рамочки
            Console.SetBufferSize(80, 25);
            Horizontalline upline = new Horizontalline(0, 78, 0, '+');
            Horizontalline downline = new Horizontalline(0, 78, 24, '+');
            Vertikalline leftline = new Vertikalline(0, 24, 0, '+');
            Vertikalline rightline = new Vertikalline(0, 24, 78, '+');
            upline.draw();
            downline.draw();
            leftline.draw();
            rightline.draw();
            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            /*p.draw();*/
            Snake1 snake=new Snake1(p, 4, Direction.right);
            snake.draw();
            Console.ReadLine();
        }
    }
}
