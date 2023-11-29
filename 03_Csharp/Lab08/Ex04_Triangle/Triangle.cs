using System.Reflection.Metadata;

public class Triangle
{
    private int sideA;
    private int sideB;
    private int sideC;
    //private bool triangleEquilateral;

    public int SideA
    {
        get => sideA;
    }
    public int SideB
    {
        get => sideB;
    }
    public int SideC
    {
        get => sideC;
    }
    //public bool Equilateral
    //{
    //    get => triangleEquilateral;
    //}
    public Triangle(int a, int b, int c)
    {
        sideA = a;
        sideB = b;
        sideC = c;
    }
    public Triangle(int a)
    {
        sideA = a;
    }

    //private bool TriangleEquilateral()
    //{
    //    Console.WriteLine("Если треугольник равностороний, введите \"Y\"");
    //    string y = Console.ReadLine();
    //    if (y == "Y" || y == "y")
    //    {
    //        return triangleEquilateral=true;
    //    }
    //    else
    //    {
    //        return triangleEquilateral=false;
    //    }
    //}

    //public void SideInitialization()
    //{
    //    TriangleEquilateral();
    //    Console.WriteLine("Укажите сторону треугольника a: ");
    //    sideA = int.Parse(Console.ReadLine());

    //    if (!triangleEquilateral)
    //    {
    //        Console.WriteLine("Укажите сторону треугольника b: ");
    //        sideB = int.Parse(Console.ReadLine());
    //        Console.WriteLine("Укажите сторону треугольника c: ");
    //        sideC = int.Parse(Console.ReadLine());
    //    }
    //}
    public int Perimeter(int sideA)
    {
        int perimeter = 3*sideA;
        return perimeter;
    }
    public int Perimeter(int sideA, int sideB, int sideC)
    {
        int perimeter = 0;
        if (TriangleExist(sideA, sideB, sideC))
        {
            perimeter = sideA + sideB + sideC;
        }
        else
        {
            Console.WriteLine("NOT Triangle!");
        }
        return perimeter;
    }
    public double Area(int a)
    {
        double area = 0;
        double p = (a + a + a) / 2.0;
        area = Math.Sqrt(p * (p - a) * (p - a) * (p - a));
        return area;
    }
    public double Area(int a, int b, int c)
    {
        double area = 0;
        if (TriangleExist(a, b, c))
        {
            double p = (a + b + c) / 2.0;
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        else
        {
            Console.WriteLine("NOT Triangle!");
        }
        return area;
    }
    public void SidePrint(int a)
    {
        Console.WriteLine($"side A: {a}");
    }
    public void SidePrint(int a, int b, int c)
    {
        Console.WriteLine($"side A: {a}");
        Console.WriteLine($"side B: {b}");
        Console.WriteLine($"side C: {c}");
    }
    public bool TriangleExist(int a)
    {
        bool ok = true;
        return ok;
    }
    public bool TriangleExist(int a, int b, int c)
    {
        bool ok;
        ok = ((a + b) > c && (b + c) > a && (c + a) > b);
        return ok;
    }


}

