namespace Ex05_Root
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag;
            double x1 = 0;
            double x2 = 0;

            Console.WriteLine("Введите коэффициент a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент c");
            double c = double.Parse(Console.ReadLine());

            flag = Root.Roots(a, b, c, ref x1, ref x2);

            if (flag == 1) 
            {
                Console.WriteLine($"Корни уравнения с коэффициентами a = {a}, b = {b}, c = {c}: x1 = {x1:F2}, x2 = {x2:F2}.");
            }
            else if (flag == 0)
            {
                Console.WriteLine($"Корень уравнения с коэффициентами a = {a}, b = {b}, c = {c}: x1 = x2 = {x1:F2}.");
            }
            else
            {
                Console.WriteLine($"Корней уравнения с коэффициентами a = {a}, b = {b}, c = {c} нет.");
            }
        }
    }

    public static class Root
    {
        internal static double Discriminant(double a, double b, double c)
        {
            double D = b*b - 4 * a * c;
            return D;
        }

        public static int Roots(double a, double b, double c, ref double x1, ref double x2)
        {
            int flag;
            double D = Discriminant(a, b, c);
            if (D > 0) 
            {
                flag = 1;
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);
            }
            else if (D == 0) 
            {
                flag = 0;
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);
            }
            else
            {
                flag = -1;
            }
            return flag;
        }

    }
}
