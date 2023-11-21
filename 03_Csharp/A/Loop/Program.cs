namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();

            int SumNumbers(string numbers)
            {
                int sum = 0;
                //цикл for, потому что известно колличество повторений цикла и надо пройти по всем
                for (int i = 0; i<numbers.Length; i++)
                {
                    int n = Convert.ToInt32(numbers[i].ToString());
                    sum += n;
                }
                return sum;
            }
            int sum = SumNumbers(numbers);
            Console.WriteLine(sum);
        }
    }
}
