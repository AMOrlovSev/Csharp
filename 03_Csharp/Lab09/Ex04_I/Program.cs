namespace Ex04_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            mag1.TakeItem();
            mag1.Show();
            mag1.IfSubs = true;
            mag1.Subs();
        }
    }
}
