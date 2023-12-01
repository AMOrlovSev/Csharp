namespace Ex03_vittual_override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013, 101, true);
            b2.TakeItem();
            b2.Show();

            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            mag1.Show();

            Console.WriteLine("\n Тестирование полиморфизма"); 

            Item it; 
            it = b2; 
            it.TakeItem(); 
            it.Return(); 
            it.Show(); 
            
            it = mag1; 
            it.TakeItem(); 
            it.Return(); 
            it.Show();
        }
    }
}
