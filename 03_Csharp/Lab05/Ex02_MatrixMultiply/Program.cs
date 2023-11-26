namespace Ex02_MatrixMultiply
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2,2]; 
            Input2(a);
            int[,] b = new int[2,2];
            Input2(b);
            int[,] result = Multiply(a, b);

            Output(result);
        }

        static int[,] Multiply(int[,] a, int[,] b)
        {
            int[,] result = new int[a.GetLength(1), b.GetLength(0)];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i,j] += a[i, 0] * b[0,j]+ a[i, 1] * b[1, j];
                }
            }

            //result[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];
            //result[0, 1] = a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1];
            //result[1, 0] = a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0];
            //result[1, 1] = a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1];
            return result;
        }

        static void Output(int[,] result)
        {
            //Console.WriteLine(result[0, 0] + "\t" + result[0, 1] + "\n"
            //    + result[1, 0] + "\t" + result[1, 1]);
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for(int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j]+"\t");
                }
                Console.WriteLine();
            }
        }

        static void Input2(int[,] a)
        {
            Console.Write($"Введите название матрицы: ");
            string name = Console.ReadLine();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"Введите индекс матрицы {name} {i},{i}: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
