using System.Reflection.Metadata;

public class Triangle : IComparable
{
    private int sideA;
    private int sideB;
    private int sideC;
    private bool triangleEquilateral;

    public int CompareTo(object obj)
    {
        Triangle triangle = obj as Triangle;
        if (this.Area(this.SideA, this.SideB, this.SideC) == triangle.Area(triangle.SideA, triangle.sideB, triangle.SideC)) return 0;
        else if (this.Area(this.SideA, this.SideB, this.SideC) > triangle.Area(triangle.SideA, triangle.sideB, triangle.SideC)) return 1;
        else return -1;
    }

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
    public bool Equilateral
    {
        get => triangleEquilateral;
    }

    private bool TriangleEquilateral()
    {
        Console.WriteLine("Если треугольник равностороний, введите \"Y\"");
        string y = Console.ReadLine();
        if (y == "Y" || y == "y")
        {
            return triangleEquilateral=true;
        }
        else
        {
            return triangleEquilateral=false;
        }
    }

    public void SideInitialization()
    {
        TriangleEquilateral();
        Console.WriteLine("Укажите сторону треугольника a: ");
        sideA = int.Parse(Console.ReadLine());

        if (!triangleEquilateral)
        {
            Console.WriteLine("Укажите сторону треугольника b: ");
            sideB = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите сторону треугольника c: ");
            sideC = int.Parse(Console.ReadLine());
        }
    }
    public void SideInitialization(int a, int b, int c)
    {
        sideA = a;
        sideB = b;
        sideC = c;
    }
    public int Perimeter(int SideA)
    {
        int perimeter = 3*SideA;
        return perimeter;
    }
    public int Perimeter(int SideA, int SideB, int SideC)
    {
        int perimeter = 0;
        if (TriangleExist(SideA, SideB, SideC))
        {
            perimeter = SideA + SideB + SideC;
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
    public void SidePrint()
    {
        Console.Write($" side A: {sideA}");
        if (!triangleEquilateral)
        {
            Console.Write($" side B: {sideB}");
            Console.WriteLine($" side C: {sideC}");
        }
    }
    public bool TriangleExist(int a, int b, int c)
    {
        bool ok;
        ok = ((a + b) > c && (b + c) > a && (c + a) > b);
        return ok;
    }


}

