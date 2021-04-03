using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = Point.CreatePoint(3, 4);
            var p2 = Point.CreatePoint(1, 2);

            var distance = p1.getDistance(p2);
        }
    }
}
