using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Point
    {
        private double x;
        private double y;

        public static Point CreatePoint(double x, double y)
        {
            var point = new Point();
            point.x = x;
            point.y = y;
            return point;
        }

        public double getDistance(Point other)
        {
            double dx = this.x - other.x;
            double dy = this.y - other.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

    }
}
