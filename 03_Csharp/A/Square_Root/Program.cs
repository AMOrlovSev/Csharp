namespace Square_Root
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double target = Double.Parse(Console.ReadLine());
            double root = Mathematics.SquareRoot(target);
            Printing.ValueSquare(root);
        }
    }

    public static class Mathematics
    {
        public static double SquareRoot(double target)
        {
            double root = 1;
            double temp;
            do
            {
                temp = root;
                root = (root + target/root)/2;
            }
            while (temp!=root);

            return root;
        }
    }

    public static class Printing
    {
        public static void ValueSquare(double value)
        {
            Console.WriteLine(value);
            Console.WriteLine(value*value);
        }
    }

}
