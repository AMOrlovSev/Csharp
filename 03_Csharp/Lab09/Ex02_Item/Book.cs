internal class Book : Item
{
    private String author;
    private String title;
    private String publisher;
    private int pages;
    private int year;
    private static double price = 9;
     public Book(String author, String title, String publisher, int pages, int year, long invNumber, bool taken) : base(invNumber, taken)
    {
        this.author = author;
        this.title = title;
        this.publisher = publisher;
        this.pages = pages;
        this.year = year;
    }
    public Book() { }
    static Book()
    {
        price = 10;
    }
    public static void SetPrice(double price)
    {
        Book.price = price;
    }
    new public void Show()
    {
        Console.WriteLine($"\nКнига:\n Автор: {author}\n Название: {title}\n Год издания: {year}\n {pages} стр.\n Стоимость аренды: {Book.price}");
        base.Show();
    }
    public double PriceBook(int s)
    {
        double cust = s * price;
        return cust;
    }
}

