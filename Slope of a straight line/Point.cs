using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slope_of_a_straight_line
{
    internal class Point
    {

        public double x;

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double y;

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(double x, double y)
        {
            this.y = y;
            this.x = x;
        }

        ~Point()
        {
            Console.WriteLine("Object is being finalized. Cleaning up resources.");
        }
    }
}
