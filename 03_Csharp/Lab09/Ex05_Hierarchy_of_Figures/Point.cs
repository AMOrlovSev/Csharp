internal struct Point
{
    public int PointX { get; set; }
    public int PointY { get; set; }
    public Point(int x, int y)
    {
        PointX = x;
        PointY = y;
    }
    public Point() { }
    public void ChangePoint(int x, int y)
    {
        PointX = x;
        PointY = y;
    }
}