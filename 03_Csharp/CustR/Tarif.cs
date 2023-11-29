class TarifTimeBased
{
    protected double priceG = 5;
    protected double priceM = 1;
    protected double Price { get; set; }
    protected double PriceG
    {
        get => priceG;
        set => priceG = value;
    }
    protected double PriceM
    {
        get => priceM;
        set => priceM = value;
    }
    public double RecordCall(char callType, int minutes)
    {
        Price = 0;
        if (callType == 'Г')
            return Price = minutes * priceG;
        else 
            if (callType == 'М')
            return Price = minutes * priceM;
        return Price;
    }
}
class TarifAfter10Minutes : TarifTimeBased
{
    private int minTarif = 10;
    private double sequenceMinutes = 2;
    private int MinTarif
    {
        get => minTarif;
        set => minTarif = value;
    }
    private double SequenceMinutes
    {
        get => sequenceMinutes;
        set => sequenceMinutes = value;
    }
    public double RecordCallAfter10Minutes(char callType, int minutes)
    {
        RecordCall(callType, minutes);
        if (minutes > MinTarif && callType == 'Г')
            Price -= (minutes - MinTarif)*(1/ SequenceMinutes) * priceG;
        return Price;
    }
}
class TarifPayLessUp : TarifTimeBased
{
    private int minTarif = 5;
    private double cheaper = 2;
    private int expensive = 2;
    private int MinTarif
    {
        get => minTarif;
        set => minTarif = value;
    }
    private double Cheaper
    {
        get => cheaper;
        set => cheaper = value;
    }
    private int Expensive
    {
        get => expensive;
        set => expensive = value;
    }
    public double RecordCallPayLessUp(char callType, int minutes)
    {
        RecordCall(callType, minutes);
        if (minutes <= MinTarif)
            Price = Price/cheaper;
        else 
            Price = Price*expensive;
        return Price;
    }
}

