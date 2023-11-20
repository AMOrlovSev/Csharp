using System;

namespace Ex01_WhatDay1
{
    internal class WhatDay
    {
        static void Main(string[] args)
        {
            int dayNum = 0;
            Console.Write("Please enter a day number between 1 and 365: ");
            try
            {
                dayNum = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Неверный ввод: {e.Message}");
            }

            if (dayNum > 0 && dayNum<=365)
            {
                int monthNum = 0;

                foreach (int daysInMonth in DaysInMonths)
                {
                    if (dayNum<= daysInMonth)
                    {
                        break;
                    }
                    else
                    {
                        dayNum -= daysInMonth;
                        monthNum++;
                    }
                }

                /*
                if (dayNum <= 31)
                { // January
                    goto End;
                }
                else
                {
                    dayNum -= 31;
                    monthNum++;
                }

                if (dayNum <= 28)
                { // February
                    goto End;
                }
                else
                {
                    dayNum -= 28;
                    monthNum++;
                }

                if (dayNum <= 31)
                { // March
                    goto End;
                }
                else
                {
                    dayNum -= 31;
                    monthNum++;
                }

                if (dayNum <= 30)
                { // April
                    goto End;
                }
                else
                {
                    dayNum -= 30;
                    monthNum++;
                }

                if (dayNum <= 31)
                { // May
                    goto End;
                }
                else
                {
                    dayNum -= 31;
                    monthNum++;
                }


                if (dayNum <= 30)
                { // June
                    goto End;
                }
                else
                {
                    dayNum -= 30;
                    monthNum++;
                }

                if (dayNum <= 31)
                { // July
                    goto End;
                }
                else
                {
                    dayNum -= 31;
                    monthNum++;
                }

                if (dayNum <= 31)
                { // August
                    goto End;
                }
                else
                {
                    dayNum -= 31;
                    monthNum++;
                }

                if (dayNum <= 30)
                { // September
                    goto End;
                }
                else
                {
                    dayNum -= 30;
                    monthNum++;
                }

                if (dayNum <= 31)
                { // October
                    goto End;
                }
                else
                {
                    dayNum -= 31;
                    monthNum++;
                }

                if (dayNum <= 30)
                { // November
                    goto End;
                }
                else
                {
                    dayNum -= 30;
                    monthNum++;
                }

                if (dayNum <= 31)
                { // December
                    goto End;
                }
                else
                {
                    dayNum -= 31;
                    monthNum++;
                }

                End:*/

                MonthName temp = (MonthName)monthNum;

                string monthName = temp.ToString();

                /*
                monthNum++;
                switch (monthNum)
                {
                    case 1:
                        monthName = "January"; break;
                    case 2:
                        monthName = "February"; break;
                    case 3:
                        monthName = "March"; break;
                    case 4:
                        monthName = "April"; break;
                    case 5:
                        monthName = "May"; break;
                    case 6:
                        monthName = "June"; break;
                    case 7:
                        monthName = "July"; break;
                    case 8:
                        monthName = "August"; break;
                    case 9:
                        monthName = "September"; break;
                    case 10:
                        monthName = "October"; break;
                    case 11:
                        monthName = "November"; break;
                    case 12:
                        monthName = "December"; break;
                    default:
                        monthName = "Не готово"; break;
                }
                */

                Console.WriteLine($"Месяц: {monthName}, День: {dayNum}");
            }
            else
            {
                Console.WriteLine($"Ввели недопустимое значение: {dayNum}");
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
