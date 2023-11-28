namespace Ex04_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Triangle triangle = new Triangle();
            //triangle.SideInitialization();
            //triangle.SidePrint();

            //int perimeter;
            //if (triangle.Equilateral)
            //{
            //    perimeter = triangle.Perimeter(triangle.SideA);
            //}
            //else
            //{
            //    perimeter = triangle.Perimeter(triangle.SideA, triangle.SideB, triangle.SideC);
            //}
            //Console.WriteLine($"perimeter: {perimeter}");

            //double area;
            //if (triangle.Equilateral)
            //{
            //    area = triangle.Area(triangle.SideA);
            //}
            //else
            //{
            //    area = triangle.Area(triangle.SideA, triangle.SideB, triangle.SideC);
            //}
            //Console.WriteLine($"area: {area:F2}");

            //bool triangleExist;
            //if (!triangle.Equilateral)
            //{
            //    triangleExist = triangle.TriangleExist(triangle.SideA, triangle.SideB, triangle.SideC);
            //    Console.WriteLine($"triangleExist: {triangleExist}");
            //}

            Random rnd = new Random();
            Triangle[] triangles = new Triangle[20];
            for (int i = 0; i < triangles.Length; i++)
            {
                triangles[i] = new Triangle();
                triangles[i].SideInitialization(rnd.Next(3, 5), rnd.Next(4, 6), rnd.Next(5, 7));
                double area = triangles[i].Area(triangles[i].SideA, triangles[i].SideB, triangles[i].SideC);
                Console.Write($"triangle befor sort: {i} area {area:F2}");
                triangles[i].SidePrint();
            }
            Array.Sort(triangles);
            for (int i = 0; i < triangles.Length; i++)
            {
                double area = triangles[i].Area(triangles[i].SideA, triangles[i].SideB, triangles[i].SideC);
                Console.Write($"triangle after sort: {i} area {area:F2}");
                triangles[i].SidePrint();
            }

        }
    }
}
