namespace Ex03_Distance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Distance UserDistance;
            UserDistance.foot = 0;
            UserDistance.inch = 0;
            try
            {
                Console.WriteLine("Введите футы:");
                UserDistance.foot = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите дюймы:");
                UserDistance.inch = Int32.Parse(Console.ReadLine());

                UserDistance.footInch = ImperialSystem.InchToFoot(UserDistance.foot, UserDistance.inch);

                Console.WriteLine($"Футы: {UserDistance.foot,20}");
                Console.WriteLine($"Дюймы: {UserDistance.inch,19}");
                Console.WriteLine($"Футы и Дюймы: {UserDistance.footInch,12}");
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
        public string footInch;
    }

    public class ImperialSystem
    {
        public static string InchToFoot(int foot, int inch)
        {
            int footMethod = foot + inch / 12;
            int inchMethod = inch % 12;
            string footInchMethod = footMethod+"'"+"-" + inchMethod+"\"";
            return footInchMethod;
        }
    }
}
