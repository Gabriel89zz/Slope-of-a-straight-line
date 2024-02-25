using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slope_of_a_straight_line
{
    internal class Line:Point
    {
       
        private Point point1;

        public Point Point1
        {
            get { return point1; }
            set { point1 = value; }
        }

        private Point point2;

        public Point Point2
        {
            get { return point2; }
            set { point2 = value; }
        }

        public Line():base()
        {
            point1=new Point(x,y);
            point2=new Point(x,y);
        }

        //method that only receives parameters
        public void LineInfo(Line ab)
        {
            Console.WriteLine("The slope of the line that passes through the points: "+ "A:(" + ab.point1.x + "," + ab.point1.y + ")" + " B:(" + ab.point2.x + "," + ab.point2.y + ")"+" is:");
        }

        public void LineInfo(double x1,double y1,double x2,double y2)
        {
            Console.WriteLine("The slope of the line that passes through the points: " + "A:(" + x1 + "," + y1 + ")" + " B:(" + x2 + "," + y2 + ")" + " is:");
        }

        //methods that receive and return
        public double GetSlope(Line ab)
        {
            double deltay=ab.point2.y-ab.point1.y;
            double deltax=ab.point2.x - ab.point1.x;
            double slope=deltay/deltax;
            return slope;
        }
        public double GetSlope(double x1,double y1,double x2,double y2)
        {
            double deltay = y2 - y1;
            double deltax = x2 - x1; 
            double slope = deltay / deltax;
            return slope;
        }

        public string GetEquation(Line ab,double slope)
        {
            double despejey1 = ab.Point1.Y * -1 * -1;
            double multi = (slope * (-1*ab.point1.x))+despejey1;
            string signo = (multi > 0)?"+":"";
            return "y=" + slope + "x"+signo+multi;
        }

        public string GetEquation(double x1, double y1,double x2,double y2)
        {
            double deltay = y2 - y1;
            double deltax = x2 - x1;
            double slope = deltay / deltax;
            double despejey1 = y1 * -1 * -1;
            double multi = (slope * (-1 * x1)) + despejey1;
            string signo = (multi > 0) ? "+" : "";
            return "y=" + slope + "x" + signo + multi;
        }

        //methods that only return
        public string ShowEquation()
        {
            return "The equation of the line is:";
        }

        //method that neither receives nor returns
        public static void GoOut()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        ~Line()
        {
            Console.WriteLine("Object is being finalized. Cleaning up resources.");
        }
    }
}
