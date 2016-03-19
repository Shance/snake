using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Vertikalline: Figure
    {
        /*List<Point> plist;*/
        public Vertikalline(int yup, int ydown, int x, char sym)
        {
            plist = new List<Point>();
            for (int y= yup; y<=ydown; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
            /*Point p1 = new Point(4, 4, '*');
            Point p2 = new Point(4, 5, '*');
            Point p3 = new Point(4, 6, '*');
            plist.Add(p1);
            plist.Add(p2);
            plist.Add(p3);*/
        }
        /*public void draw()
        {
            foreach (Point p in plist)
            {
                p.draw();
            }
        }*/
    }
}
