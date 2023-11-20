namespace Ex04_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfShots = 0;
            try
            {
                Console.Write("Колличество выстрелов: ");
                numberOfShots = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Неверный ввод: {e.Message}");
            }

            TargetCenter UserTargetCenter;
            UserTargetCenter.targetCenterX = 0;
            UserTargetCenter.targetCenterY = 0;

            Console.WriteLine("Для активации стрельбы вслепую введите \"Y\" ");
            string blindyActivation = Console.ReadLine();
            if (blindyActivation =="Y" || blindyActivation == "y")
            {
                var rand = new Random();
                UserTargetCenter.targetCenterX = rand.Next(10);
                UserTargetCenter.targetCenterY = rand.Next(10);
                //Console.WriteLine($"Центр мишени по X: {UserTargetCenter.targetCenterX} и по Y: {UserTargetCenter.targetCenterY} ");
            }

            int points = 0;

            for (int i = 1; i<=numberOfShots; i++)
            {
                Shot UserShot;
                UserShot.shotX = 0;
                UserShot.shotY = 0;
                try
                {
                    Console.WriteLine($"выстрел {i} ");
                    Console.WriteLine("по X: ");
                    UserShot.shotX = int.Parse(Console.ReadLine());
                    Console.WriteLine("по Y: ");
                    UserShot.shotY = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Неверный ввод: {e.Message}");
                    break;
                }
                //Console.WriteLine($"выстрел {i} по X: {UserShot.shotX} и Y: {UserShot.shotY} ");

                double accuracy = Target.ShotAccuracy(UserShot.shotX, UserShot.shotY, UserTargetCenter.targetCenterX, UserTargetCenter.targetCenterY);
                //Console.WriteLine($"Точность выстрела: {accuracy:F2}");

                points += Target.ShotPoints(accuracy);
                //Console.WriteLine($"Очки: {points}");
            }
            Console.WriteLine($"Очки: {points}");
        }
    }

    public struct Shot
    {
        public int shotX;
        public int shotY;
    }
    public struct TargetCenter
    {
        public int targetCenterX;
        public int targetCenterY;
    }
    enum TargetPoints : int
    {
        level1 = 10,
        level2 = 5,
        level3 = 1,
        level4 = 0
    }
    enum TargetLevels : int
    {
        level1 = 1,
        level2 = 2,
        level3 = 3
    }

    public class Target
    {
        public static double ShotAccuracy(int shotX, int shotY, int targetX, int targetY)
        {
            int deltaX = Math.Abs(shotX - targetX);
            int deltaY = Math.Abs(shotY - targetY);
            double accuracy = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            return accuracy;
        }
        public static int ShotPoints(double accuracy)
        {
            int count = 0;
            if (accuracy <= (int)TargetLevels.level1)
                {
                count = (int)TargetPoints.level1;
                }
            else if ((accuracy > (int)TargetLevels.level1) && (accuracy <= (int)TargetLevels.level2))
                {
                count = (int)TargetPoints.level2;
                }
            else if ((accuracy > (int)TargetLevels.level2) && (accuracy <= (int)TargetLevels.level3))
                {
                    count = (int)TargetPoints.level3;
                }
            return count;
        }
    }
}
