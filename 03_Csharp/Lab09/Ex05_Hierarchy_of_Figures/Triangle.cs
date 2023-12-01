using System.Drawing;

internal class Triangle : Shape
{
    public int SideA { get; set; }
    public int SideB { get; set; }
    public int SideC { get; set; }


    public Triangle()
    {
        Color = base.Color;
        Name = "Треугольник";
        SideA = 10;
        SideB = SideA;
        SideC = SideB;
    }
    public Triangle(int a) : this()
    {
        SideA = a;
        SideB = SideA;
        SideC = SideB;
    }
    public Triangle(int a, int b, int c) : this()
    {
        SideA = a;
        SideB = b;
        SideC = c;
    }
    public override void ChangeBasePoint(int x, int y)
    {
        basePoint.PointX = x;
        basePoint.PointY = y;
    }
    public override double Perimeter()
    {
        double perimeter = SideA + SideB + SideC;
        return perimeter;
    }
    private bool TriangleExist()
    {
        bool ok;
        ok = ((SideA + SideB) > SideC && (SideB + SideC) > SideA && (SideC + SideA) > SideB);
        return ok;
    }
    public override double Area()
    {
        double area = 0;
        if (TriangleExist())
        {
            double p = (SideA + SideB + SideC) / 2.0;
            area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        else
        {
            Console.ForegroundColor = Color;
            Console.WriteLine("NOT Triangle!");
            Console.ResetColor();
        }
        return area;
    }
    private bool TriangleEquilateral()
    {
        bool triangleEquilateral = SideA == SideB && SideA == SideC;
        return triangleEquilateral;
    }
    public override void Show()
    {
        if (TriangleEquilateral())
        {
            Console.ForegroundColor = Color;
            Console.WriteLine($"Фигура: {Name}\t Сторона: {SideA}\t Периметр: {Perimeter():F2}\t Площадь: {Area():F2}\n" +
                $"Координаты базовой точки: \t({basePoint.PointX},{basePoint.PointY})");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = Color;
            Console.WriteLine($"Фигура: {Name}\t Стороны: {SideA},{SideB},{SideC}\t Периметр: {Perimeter():F2}\t Площадь: {Area():F2}\n" +
                $"Координаты базовой точки: \t({basePoint.PointX},{basePoint.PointY})");
            Console.ResetColor();
        }
    }
}