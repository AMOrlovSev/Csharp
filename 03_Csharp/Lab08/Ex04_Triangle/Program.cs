namespace Ex04_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = 3;
            int s2 = 4;
            int s3 = 5;

            Triangle triangle1 = new Triangle(s1);
            triangle1.SidePrint(triangle1.SideA);
            triangle1.TriangleExist(triangle1.SideA);
            Console.WriteLine($"triangleExist: {triangle1.TriangleExist(triangle1.SideA)}");
            Console.WriteLine($"perimeter: {triangle1.Perimeter(triangle1.SideA)}");
            Console.WriteLine($"area: {triangle1.Area(triangle1.SideA):F2}");

            Triangle triangle3 = new Triangle(s1,s2,s3);
            triangle1.SidePrint(triangle3.SideA, triangle3.SideB, triangle3.SideC);
            triangle1.TriangleExist(triangle3.SideA, triangle3.SideB, triangle3.SideC);
            Console.WriteLine($"triangleExist: {triangle1.TriangleExist(triangle3.SideA, triangle3.SideB, triangle3.SideC)}");
            Console.WriteLine($"perimeter: {triangle1.Perimeter(triangle3.SideA, triangle3.SideB, triangle3.SideC)}");
            Console.WriteLine($"area: {triangle1.Area(triangle3.SideA, triangle3.SideB, triangle3.SideC):F2}");
        }
    }
}
