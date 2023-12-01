namespace Ex05_Hierarchy_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // для проверки
            Circle circle1 = new Circle();
            circle1.Show();
            Circle circle2 = new Circle(25);
            circle2.Show();
            Circle circle3 = new Circle(20, ConsoleColor.DarkBlue, "333", 50, 50);
            circle3.Show();
            circle3.ChangeBasePoint(100, 0);
            circle3.Name = "qwert";
            circle3.Radius = 50;
            circle3.Show();
            Circle circle4 = new Circle(120, ConsoleColor.Cyan, "333", 50, 50);
            circle4.Show();
            Circle circle5 = new Circle();
            circle5.Show();

            Shape shape1 = new Square();
            Shape shape2 = new Square(20);
            Shape shape3 = new Square(30, ConsoleColor.DarkMagenta, "456789", 50, 250);
            shape1.Show();
            shape2.Show();
            shape3.Show();

            Shape shape4 = new Triangle();
            Shape shape5 = new Triangle(20);
            Shape shape6 = new Triangle(3, 4, 5);
            shape4.ChangeBasePoint(100, 0);
            shape4.Show();
            shape5.Color = ConsoleColor.Red;
            shape5.Show();
            shape6.Name = "sfrtjsrtjk";
            shape6.Show();

            Square square1 = new Square();
            square1.Show();
            square1.PrintBasePoint();
            square1.RotateBasePointPolygon();
            square1.RotateBasePointPolygon();
            square1.RotateBasePointPolygon();
            square1.RotateBasePointPolygon();

            Random rand = new Random();

            List<Shape> shapes = new List<Shape>();
            for (var index = 0; index < 3; index++)
            {
                shapes.Add(new Circle(rand.Next(1,50)));
                shapes.Add(new Square(rand.Next(1, 50)));
                shapes.Add(new Triangle(rand.Next(1, 50)));
            }
            foreach (var shape in shapes)
            {
                shape.Show();
            }
        }
    }
}
