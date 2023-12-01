internal class Circle : Shape
{
    public int Radius { get; set; }

    public Circle()
    {
        Color = base.Color;
        Name = "Окружность";
        Radius = 10;
    }
    public Circle(int r) : this()
    {
        Radius = r;
    }
    public Circle(int radius, ConsoleColor color, string name, int x, int y) : base(color, name, x, y)
    {
        Radius = radius;
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
    public double Diameter()
    {
        double diameter = 2 *Radius;
        return diameter;
    }
    public override double Perimeter()
    {
        double perimeter = 2 * Math.PI * Radius;
        return perimeter;
    }
    public override double Area()
    {
        double area = Math.PI * Radius * Radius;
        return area;
    }
    public override void Show()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine($"Фигура: {Name}\t Радиус: {Radius}\t Диаметр: {Diameter()}\t Периметр: {Perimeter():F2}\t Площадь: {Area():F2}\n" +
            $"Координаты базовой точки: \t({ basePoint.PointX},{ basePoint.PointY})");
        Console.ResetColor();
    }
}
