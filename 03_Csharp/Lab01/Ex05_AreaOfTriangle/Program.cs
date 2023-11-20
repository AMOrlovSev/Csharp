namespace Ex05_TriangleGeometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Perimeter = 0;
            try
            {
                Console.WriteLine("Введите периметр треугольника");
                Perimeter = Double.Parse(Console.ReadLine());
                double side = TriangleGeometry.TriangleSide(Perimeter);
                Console.WriteLine($"Сторона: {side,10:F2}");
                double area = TriangleGeometry.TriangleArea(Perimeter);
                Console.WriteLine($"Площадь: {area,10:F2}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Неверный ввод: {e.Message}");
            }
        }
    }

    static class TriangleGeometry
    {
        static public double TriangleSide(double Perimeter)
        {
            double side = Perimeter / 3;
            return side;
        }

        static public double TriangleArea(double Perimeter)
        {
            double side = TriangleSide(Perimeter);
            double semiPerimeter = Perimeter / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - side) * (semiPerimeter - side) * (semiPerimeter - side));
            return area;
        }
    }


}
