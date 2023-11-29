namespace CustR
{
    class Customer
    {
        public string Name { get; set; }
        public double Balance { get; private set; }
        public Customer(string name, double balance = 100)
        {
            Name = name;
            Balance = balance;
        }
        public override string ToString()
        {
            return string.Format($"Клиент: {Name} имеет баланс: {Balance}");
        }

        public void RecordPayment(double amountPaid)
        {
            if (amountPaid > 0)
                Balance += amountPaid;
        }
        public void RecordTarif(int tarif, char callType, int minutes)
        {
            switch (tarif)
            {
                case 0:
                    TarifTimeBased tarifTimeBased = new TarifTimeBased();
                    Balance -= tarifTimeBased.RecordCall(callType, minutes);
                    break;
                case 1:
                    TarifAfter10Minutes tarifAfter10Minutes = new TarifAfter10Minutes();
                    Balance -= tarifAfter10Minutes.RecordCallAfter10Minutes(callType, minutes);
                    break;
                case 2:
                    TarifPayLessUp tarifPayLessUp = new TarifPayLessUp();
                    Balance -= tarifPayLessUp.RecordCallPayLessUp(callType, minutes);
                    break;
                default:
                    Console.WriteLine("Неправильно указан тариф");
                    break;
            }
        }
    }

    class Customer1
    {
        static void Main(string[] args)
        {
            Customer Ivan = new Customer("Иван Петров", 500);
            Customer Elena = new Customer("Елена Иванова");
            Ivan.RecordTarif(0,'Г', 12);
            Elena.RecordTarif(1,'М', 25);

            Console.WriteLine(Ivan);
            Console.WriteLine(Elena);

            // тестирование всех возможных вариантов
            // цифра после имени - вариант тарифа
            // g/m после цифры - городской или мобильный
            // b/m в конце имени - больше или меньше условий тарифа

            Customer Ivan0g = new Customer("Иван0g", 500);
            Ivan0g.RecordTarif(0, 'Г', 10);
            Console.WriteLine(Ivan0g);

            Customer Ivan0m = new Customer("Иван0m", 500);
            Ivan0m.RecordTarif(0, 'М', 10);
            Console.WriteLine(Ivan0m);

            Customer Ivan1gm = new Customer("Иван1gm", 500);
            Ivan1gm.RecordTarif(1, 'Г', 10);
            Console.WriteLine(Ivan1gm);

            Customer Ivan1gb = new Customer("Иван1gb", 500);
            Ivan1gb.RecordTarif(1, 'Г', 20);
            Console.WriteLine(Ivan1gb);

            Customer Ivan1mm = new Customer("Иван1mm", 500);
            Ivan1mm.RecordTarif(1, 'М', 10);
            Console.WriteLine(Ivan1mm);

            Customer Ivan1mb = new Customer("Иван1mb", 500);
            Ivan1mb.RecordTarif(1, 'М', 20);
            Console.WriteLine(Ivan1mb);

            Customer Ivan2gm = new Customer("Иван2gm", 500);
            Ivan2gm.RecordTarif(2, 'Г', 5);
            Console.WriteLine(Ivan2gm);

            Customer Ivan2gb = new Customer("Иван2gb", 500);
            Ivan2gb.RecordTarif(2, 'Г', 10);
            Console.WriteLine(Ivan2gb);

            Customer Ivan2mm = new Customer("Иван2mm", 500);
            Ivan2mm.RecordTarif(2, 'М', 5);
            Console.WriteLine(Ivan2mm);

            Customer Ivan2mb = new Customer("Иван2mb", 500);
            Ivan2mb.RecordTarif(2, 'М', 10);
            Console.WriteLine(Ivan2mb);
        }
    }
}
