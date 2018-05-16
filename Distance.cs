public struct Point
{
    public double x;
    public double y;
}
public abstract class Distance
{
    public abstract double CalcDistance(Point a, Point b);
}
public class EuclideanDistance : Distance
{
    public override double CalcDistance(Point a, Point b)
    {
        return Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));
    }
}
public class ManhattanDistance : Distance
{
    public override double CalcDistance(Point a, Point b)
    {
        return Math.Abs(a.x - b.x) + Math.Abs(a.y - b.y);
    }
}