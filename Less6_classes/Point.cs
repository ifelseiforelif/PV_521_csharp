using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less6_classes
{
    internal class Point
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"X: {X} Y: {Y}";
        }
        public static Point operator+(Point obj, int n)
        {
            Point p = new Point(obj.X+n, obj.Y+n);
            return p;
        }
    }
}
