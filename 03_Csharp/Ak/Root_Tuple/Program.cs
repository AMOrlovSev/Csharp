namespace Root_Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициент a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент c");
            double c = double.Parse(Console.ReadLine());

            (int? flag, double? x1, double? x2) RootTuple(double a, double b, double c)
            {
                int? flag = null;
                double? x1 = null;
                double? x2 = null;
                double D = Root.Discriminant(a, b, c);
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
                return (flag, x1, x2);
            }

            var answer = RootTuple(a, b, c);

            if (answer.flag == 1)
            {
                Console.WriteLine($"Корни уравнения с коэффициентами a = {a}, b = {b}, c = {c}: x1 = {answer.x1:F2}, x2 = {answer.x2:F2}.");
            }
            else if (answer.flag == 0)
            {
                Console.WriteLine($"Корень уравнения с коэффициентами a = {a}, b = {b}, c = {c}: x1 = x2 = {answer.x1:F2}.");
            }
            else
            {
                Console.WriteLine($"Корней уравнения с коэффициентами a = {a}, b = {b}, c = {c} нет.");
            }
        }
    }

    public class Root
    {
        internal static double Discriminant(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            return D;
        }
    }
}
