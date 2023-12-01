internal class Item
{
    // инвентарный номер — целое число
    protected long invNumber;
    // хранит состояние объекта - взят ли на руки
    protected bool taken;
    public Item(long invNumber, bool taken)
    {
        this.invNumber = invNumber;
        this.taken = taken;
    }
    public Item()
    {
        this.taken = true;
    }

    // истина, если этот предмет имеется в библиотеке
    public bool IsAvailable()
    {
        if (taken == true)
            return true;
        else
            return false;
    }

    // инвентарный номер
    public long GetInvNumber()
    {
        return invNumber;
    }

    // операция "взять"
    private void Take()
    {
        taken = false;
    }

    // операция "вернуть"
    public void Return()
    {
        taken = true;
    }
    public void TakeItem()
    {
        if (this.IsAvailable())
            this.Take();
    }
    public void Show()
    {
        Console.WriteLine($"Состояние единицы хранения:\n Инвентарный номер: {invNumber}\n Наличие: {taken}");
    }

}

