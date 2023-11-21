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

                Distance UserDistance3 = ImperialSystem.DistanceSum(UserDistance1, UserDistance2);

                string distance1 = ImperialSystem.InchToFoot(UserDistance1);
                string distance2 = ImperialSystem.InchToFoot(UserDistance2);
                string distance3 = ImperialSystem.InchToFoot(UserDistance3);

                Console.WriteLine(distance1);
                Console.WriteLine(distance2);
                Console.WriteLine(distance3);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Неверный ввод: {e.Message}");
            }
        }
    }
    public struct Distance
    {
        public int foot;
        public int inch;
        public Distance()
        {

        }
    }

    public class ImperialSystem
    {
        public static Distance UserD(int i)
        {
            Distance UserD;
            Console.Write($"Введите футы {i}: ");
            UserD.foot = Int32.Parse(Console.ReadLine());
            Console.Write($"Введите дюймы {i}: ");
            UserD.inch = Int32.Parse(Console.ReadLine());
            return UserD;
        }

        public static Distance DistanceSum(Distance D1, Distance D2)
        {
            Distance D;
            D.foot = D1.foot + D2.foot;
            D.inch = D1.inch + D2.inch;
            return D;
        }

        public static string InchToFoot(Distance D)
        {
            int footMethod = D.foot + D.inch / 12;
            int inchMethod = D.inch % 12;
            string footInchMethod = footMethod+"'"+"-" + inchMethod+"\"";
            return footInchMethod;
        }
    }
}
