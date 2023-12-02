using System;
using System.ComponentModel.Design;
using System.Drawing;
using System.Xml.Linq;

namespace Ex03_Distance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Distance UserDistance1 = ImperialSystem.UserD(1);
                Distance UserDistance2 = ImperialSystem.UserD(2);

                Distance UserDistance3 = UserDistance1 + UserDistance2;
                Distance UserDistance4 = UserDistance1 - UserDistance2;

                string distance1 = ImperialSystem.InchToFoot(UserDistance1);
                string distance2 = ImperialSystem.InchToFoot(UserDistance2);

                Console.WriteLine(distance1);
                Console.WriteLine(distance2);

                Console.WriteLine(UserDistance3);
                Console.WriteLine(UserDistance4);

                int result1 = UserDistance1.CompareTo(UserDistance2);
                Console.WriteLine(result1);
                int result2 = UserDistance3.CompareTo(UserDistance4);
                Console.WriteLine(result2);
                int result3 = UserDistance4.CompareTo(UserDistance3);
                Console.WriteLine(result3);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Неверный ввод: {e.Message}");
            }
        }
    }
    public class Distance : IComparable
    {
        public int Foot {  get; set; }
        public int Inch { get; set; }
        public Distance()
        {

        }
        public Distance(int foot, int inch)
        {
            Foot = foot;
            Inch = inch;
        }
        public static Distance operator + (Distance D1, Distance D2)
        {
            Distance D = new Distance();
            D = ImperialSystem.DistanceSum(D1, D2);
            D = ImperialSystem.DistanceResult(D);
            return D;
        }
        public static Distance operator - (Distance D1, Distance D2)
        {
            int tempInch = D1.Foot*12+D1.Inch-D2.Foot*12 - D2.Inch;
            Distance D = new Distance();
            D.Foot = tempInch / 12;
            D.Inch = tempInch % 12;
            return D;
        }
        public override string ToString()
        {
            string d = Foot + "'" + "-" + Inch + "\"";
            return d;
        }
        public int CompareTo(Object D)
        {
            Distance d = (Distance)D;
            if (D is Distance)
            {
                if ((this.Foot * 12 + this.Inch) > (d.Foot * 12 + d.Inch))
                    return 1;
                else if ((this.Foot * 12 + this.Inch) == (d.Foot * 12 + d.Inch))
                    return 0;
                else
                    return -1;
            }
            else 
                throw new ArgumentException("Некорректное значение параметра");
        }
    }


    public class ImperialSystem
    {
        public static Distance UserD(int i)
        {
            Distance UserD = new Distance();
            Console.Write($"Введите футы {i}: ");
            UserD.Foot = Int32.Parse(Console.ReadLine());
            Console.Write($"Введите дюймы {i}: ");
            UserD.Inch = Int32.Parse(Console.ReadLine());
            return UserD;
        }

        public static Distance DistanceSum(Distance D1, Distance D2)
        {
            Distance D = new Distance();
            D.Foot = D1.Foot + D2.Foot;
            D.Inch = D1.Inch + D2.Inch;
            return D;
        }
        public static Distance DistanceResult(Distance D)
        {
            int footMethod = D.Foot + D.Inch / 12;
            int inchMethod = D.Inch % 12;
            D.Foot = footMethod;
            D.Inch = inchMethod;
            return D;
        }
        public static string InchToFoot(Distance D)
        {
            int footMethod = D.Foot + D.Inch / 12;
            int inchMethod = D.Inch % 12;
            string footInchMethod = footMethod+"'"+"-" + inchMethod+"\"";
            return footInchMethod;
        }
    }
}
