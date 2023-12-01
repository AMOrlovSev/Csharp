internal class Magazine : Item
{
    private String volume; // том
    private int number; // номер
    private String title; // название
    private int year; // год выпуска
    public Magazine(String volume, int number, String title, int year, long invNumber, bool taken) : base(invNumber, taken)
    {
        this.volume = volume;
        this.number = number;
        this.title = title;
        this.year = year;
    }
    public Magazine()
    { }
    new public void Show()
    {
        Console.WriteLine($"\nЖурнал:\n Том: {volume}\n Номер: {number}\n Название: {title}\n  Год выпуска: {year}");
        base.Show();
    }
}


