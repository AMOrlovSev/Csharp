namespace Ex02_Item
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item();
            item1.Show();
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013, 101, true);
            b2.TakeItem();
            b2.Show();

            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            mag1.Show();
        }
    }
}
