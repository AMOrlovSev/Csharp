namespace Ex04_Divider
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = DivideIt.EnteringNumber("первое");
            int number2 = DivideIt.EnteringNumber("второе");

            try
            {
                int result = DivideIt.CompleteDivision(number1, number2);
                Console.WriteLine($"Результат деления {number1} на {number2} число {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Исключение: {e.Message}");
            }
        }
    }       

    static class DivideIt
    {
        //метод получает на вход последовательность ввода числа и возвращает int
        public static int EnteringNumber(string order)
        { 
            int x = 0; // не нравится, что не обойтись без присвоения 0
            try
            {
                Console.WriteLine($"Введите {order} целое число");
                string temp = Console.ReadLine();
                x = Int32.Parse(temp);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Неверный ввод: {e.Message}");
            }
            return x;
        }
        //Целочисленное деление двух целочисленных чисел
        public static int CompleteDivision(int x1, int x2)
        {
            int result = x1 / x2;
            return result;
        }
    }

}
