namespace Ex04_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.SideInitialization();
            triangle.SidePrint();

            int perimeter;
            if (triangle.Equilateral)
            {
                perimeter = triangle.Perimeter(triangle.SideA);
            }
            else
            {
                perimeter = triangle.Perimeter(triangle.SideA, triangle.SideB, triangle.SideC);
            }
            Console.WriteLine($"perimeter: {perimeter}");

            double area;
            if (triangle.Equilateral)
            {
                area = triangle.Area(triangle.SideA);
            }
            else
            {
                area = triangle.Area(triangle.SideA, triangle.SideB, triangle.SideC);
            }
            Console.WriteLine($"area: {area:F2}");

            bool triangleExist;
            if (!triangle.Equilateral)
            {
                triangleExist = triangle.TriangleExist(triangle.SideA, triangle.SideB, triangle.SideC);
                Console.WriteLine($"triangleExist: {triangleExist}");
            }

        }
    }
}
