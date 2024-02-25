using Slope_of_a_straight_line;
Point a = new Point();
Point b = new Point();
a.X = 2;
a.Y = 1;
b.X = 4;  
b.Y = 5;

Line line1=new Line();
line1.Point1 = a;
line1.Point2 = b;
line1.LineInfo(line1);
double slope = line1.GetSlope(line1);
Console.WriteLine(slope);
Console.WriteLine(line1.ShowEquation());
Console.WriteLine(line1.GetEquation(line1,slope)+"\n");

Line line2 = new Line();
double slope_line2 = line2.GetSlope(7,8,2,5);
line2.LineInfo(7,8,2,5);
Console.WriteLine(slope_line2);
Console.WriteLine(line2.ShowEquation());
Console.WriteLine(line2.GetEquation(7,8,2,5));
Line.GoOut();