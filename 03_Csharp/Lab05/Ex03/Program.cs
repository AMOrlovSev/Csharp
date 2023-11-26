using System;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(0,100);
            Console.WriteLine($"Чисел массива: {number}");

            int[] array = new int[number];

            ArrayInitializationRandom(array);
            ArrayPrint(array);

            int sum = ArraySum(array);
            Console.WriteLine($"Сумма массива: {sum}");

            double mid = ArrayMid(array);
            Console.WriteLine($"Среднее значение массива: {mid:F2}");

            int sumPositive = ArraySumPositive(array);
            Console.WriteLine($"Сумма положительных элементов массива: {sumPositive}");

            int sumNegative = ArraySumNegative(array);
            Console.WriteLine($"Сумма отрицательных элементов массива: {sumNegative}");

            int sumEven = ArraySumEven(array);
            Console.WriteLine($"Сумма четных элементов массива: {sumEven}");

            int sumOdd = ArraySumOdd(array);
            Console.WriteLine($"Сумма нечетных элементов массива: {sumOdd}");

            ArrayMax(array, out int max, out int indexMax);
            Console.WriteLine($"Максимальное значение массива {max}, соответствующий индекс {indexMax}");

            ArrayMin(array, out int min, out int indexMin);
            Console.WriteLine($"Максимальное значение массива {min}, соответствующий индекс {indexMin}");

            int sumMaxMin = ArraySumBetweenMaxMin(array);
            Console.WriteLine($"Сумма массива между максимальным и минимальным: {sumMaxMin}");
        }

        public static int[] ArrayInitializationRandom(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
            }
            return array;
        }
        public static int[] ArrayInitialization(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите значение {i+1}-го элемента массива из {array.Length}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        public static void ArrayPrint(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i} элемент массива равен: {array[i]}");
            }
        }

        public static int ArraySum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static double ArrayMid(int[] array)
        {
            double mid = ArraySum(array)/Convert.ToDouble(array.Length);
            return mid;
        }
        public static int ArraySumPositive(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
        public static int ArraySumNegative(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        public static int ArraySumEven(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        public static int ArraySumOdd(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
        public static void ArrayMax(int[] array, out int max, out int f)
        {
            max = int.MinValue;
            f = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    f = i;
                }
            }
        }
        public static void ArrayMin(int[] array, out int min, out int f)
        {
            min = int.MaxValue;
            f = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    f = i;
                }
            }
        }
        public static int ArraySumBetweenMaxMin(int[] array)
        {
            int sumMaxMin = 0;
            ArrayMax(array, out int max, out int indexMax);
            ArrayMin(array, out int min, out int indexMin);
            if (indexMax > indexMin)
            {
                int temp = indexMin;
                while (temp <= indexMax)
                {
                    sumMaxMin += array[temp];
                    temp++;
                }
            }
            else
            {
                int temp = indexMax;
                while (temp <= indexMin)
                {
                    sumMaxMin += array[temp];
                    temp++;
                }
            }
            return sumMaxMin;
        }

    }
}
