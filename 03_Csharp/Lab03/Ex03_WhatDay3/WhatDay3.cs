using System.ComponentModel.DataAnnotations;

namespace Ex03_WhatDay3
{
    internal class WhatDay3
    {
        static void Main(string[] args)
        {
            int yearNum = 0;
            int dayNum = 0;
            int maxDayNum=0;
            bool isLeapYear = true;
            try
            {
                Console.Write("Please enter a year number: ");
                yearNum = int.Parse(Console.ReadLine());
                isLeapYear = (yearNum % 4 == 0) && (yearNum % 100 != 0 || yearNum % 400 == 0);
                /* if (isLeapYear)
                {
                    Console.WriteLine($"Год {yearNum} высокосный");
                }
                else
                {
                    Console.WriteLine($"Год {yearNum} не высокосный");
                } */
                maxDayNum = isLeapYear ? 366 : 365;

                Console.Write($"Please enter a day number between 1 and {maxDayNum}: ");
                dayNum = int.Parse(Console.ReadLine());

                if (dayNum <= 0 || dayNum > maxDayNum)
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

            if (dayNum > 0 && dayNum <= maxDayNum)
            {
                int monthNum = 0;
                if (isLeapYear)
                {
                    foreach (int daysInMonth in DaysInLeapMonths)
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
                }
                else
                {
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
                }

                MonthName temp = (MonthName)monthNum;

                string monthName = temp.ToString();

                Console.WriteLine($"Месяц: {monthName}, День: {dayNum}");
            }
        }
        static System.Collections.ICollection DaysInLeapMonths
            = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
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