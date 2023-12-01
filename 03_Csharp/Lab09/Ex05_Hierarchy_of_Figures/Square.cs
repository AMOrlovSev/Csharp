using System.Diagnostics.Metrics;
using System.Xml.Linq;

internal class Square : Shape, IRotateBasePointPolygon
{
    int Ipoint = 1;
    public int IPoint
    {
        get => Ipoint;
        set => Ipoint = value;
    }
    public void RotateBasePointPolygon()
    {
        switch (IPoint)
        {
            case 1:
                ChangeBasePoint(basePoint.PointX + 0, basePoint.PointY + Side);
                IPoint++;
                PrintBasePoint();
                break;
            case 2:
                ChangeBasePoint(basePoint.PointX + Side, basePoint.PointY + 0);
                IPoint++;
                PrintBasePoint();
                break;
            case 3:
                ChangeBasePoint(basePoint.PointX + 0, basePoint.PointY - Side);
                IPoint++;
                PrintBasePoint();
                break;
            case 4:
                ChangeBasePoint(basePoint.PointX - Side, basePoint.PointY - 0);
                IPoint = 1;
                PrintBasePoint();
                break;
        }
    }
    public void PrintBasePoint()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine($"Базовая точка {IPoint} в координате {basePoint.PointX},{basePoint.PointY}");
        Console.ResetColor();
    }
    public int Side { get; set; }

    public Square()
    {
        Color = base.Color;
        Name = "Квадрат";
        Side = 10;
    }
    public Square(int a) : this()
    {
        Side = a;
    }
    public Square(int side, ConsoleColor color, string name, int x, int y) : base(color, name, x, y)
    {
        Side = side;
        base.Color = color;
        base.Name = name;
        base.basePoint.PointX = x;
        base.basePoint.PointY = y;
    }
    public override void ChangeBasePoint(int x, int y)
    {
        basePoint.PointX = x;
        basePoint.PointY = y;
    }
    public double Diagonal()
    {
        double diagonal = Math.Sqrt(2 * Side);
        return diagonal;
    }
    public override double Perimeter()
    {
        double perimeter = 4 * Side;
        return perimeter;
    }
    public override double Area()
    {
        double area = Side*Side;
        return area;
    }
    public override void Show()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine($"Фигура: {Name}\t Сторона: {Side}\t Диагональ: {Diagonal():F2}\t Периметр: {Perimeter():F2}\t Площадь: {Area():F2}\n" +
            $"Координаты базовой точки: \t({basePoint.PointX},{basePoint.PointY})");
        Console.ResetColor();
    }
}