internal abstract class Shape
{
    public ConsoleColor Color { get; set; }
    public string Name { get; set; }
    // для окружности и овала BasePoint - центр, для остальных фигут - нижняя левая вершина
    protected Point basePoint = new Point();
    static int counter = 0;
    protected Random random = new Random();

    public Shape()
    {
        Color = (ConsoleColor)random.Next(1, 15);
        Name = "Фигура";
        Counter();
    }
    public Shape(ConsoleColor color, string name, int x, int y)
    {
        Color = color;
        Name = name;
        basePoint.PointX = x;
        basePoint.PointY = y;
        Counter();
    }
    public abstract double Perimeter();
    public abstract double Area();
    public virtual void ChangeBasePoint(int x, int y)
    {
        basePoint.PointX = x;
        basePoint.PointY = y;
    }

    public virtual void Show()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine($"Фигура:\t {Name}, Координаты базовой точки: \t({basePoint.PointX},{basePoint.PointY})");
        Console.ResetColor();
    }
    private void Counter()
    {
        counter++;
        Console.ForegroundColor = Color;
        Console.WriteLine($"Фигура {counter} создана");
        Console.ResetColor();
    }
}
