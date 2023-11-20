namespace Ex02_WhatDay2
{
    internal class WhatDay2
    {
        static void Main(string[] args)
        {
            int dayNum = 0;
            Console.Write("Please enter a day number between 1 and 365: ");
            try
            {
                dayNum = int.Parse(Console.ReadLine());
                if (dayNum <= 0 || dayNum > 365)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Неверный ввод: {e.Message}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Неверный ввод: {e.Message}");
            }

            if (dayNum > 0 && dayNum <= 365)
            {
                int monthNum = 0;

            foreach (int daysInMonth in DaysInMonths)
            {
                if (dayNum <= daysInMonth)
                {
                    break;
                }
                else
                {
                    dayNum -= daysInMonth;
                    monthNum++;
                }
            }

            MonthName temp = (MonthName)monthNum;

            string monthName = temp.ToString();

                Console.WriteLine($"Месяц: {monthName}, День: {dayNum}");
            }
        }
        static System.Collections.ICollection DaysInMonths
            = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    }
    enum MonthName
    {
        Январь,
        Февраль,
        Март,
        Апрель,
        Май,
        Июнь,
        Июль,
        Август,
        Сентябрь,
        Октябрь,
        Ноябрь,
        Декабрь
    }
}

