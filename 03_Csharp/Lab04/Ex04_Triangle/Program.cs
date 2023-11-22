namespace Ex04_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Если треугольник равностороний, введите \"Y\"");
            string y = Console.ReadLine();

            Console.WriteLine("Укажите сторону треугольника a: ");
            int a = int.Parse(Console.ReadLine());
            double area;

            if (y!="Y" && y!="y")
            {
                Console.WriteLine("Укажите сторону треугольника b: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Укажите сторону треугольника c: ");
                int c = int.Parse(Console.ReadLine());
                area = Operation.TriangleArea(a, b, c);
            }
            else
            {
                area = Operation.TriangleArea(a);
            }

            if (area != 0)
            {
                Console.WriteLine($"Площадь треугольника: {area:F2}");
            }
        }
    }

    public static class Operation
    {
        public static double TriangleArea(int a, int b, int c)
        {   
            bool ok = TriangleExist(a, b, c);
            double area = 0;
            if (ok)
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
        public static double TriangleArea(int a)
        {
            bool ok = TriangleExist(a, a, a);
            double area = 0;
            if (ok)
            {
                double p = (a + a + a) / 2.0;
                area = Math.Sqrt(p * (p - a) * (p - a) * (p - a));
            }
            else
            {
                Console.WriteLine("NOT Triangle!");
            }
            return area;
        }

        internal static bool TriangleExist(int a, int b, int c)
        {
            bool ok;
            ok = ((a+b)>c && (b+c)>a && (c+a)>b);
            return ok;
        }

    }
}
