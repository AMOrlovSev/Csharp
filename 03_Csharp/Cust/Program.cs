namespace Cust
{
    class Customer
    {
        public string Name { get; set; }
        public double Balance { get; private set; }
        private double priceG = 5;
        private double priceM = 1;

        public Customer(string name, double balance = 100)
        {
            Name = name;
            Balance = balance;
        }

        public override string ToString()
        {
            return string.Format("Клиент: {0} имеет баланс: {1}", Name, Balance);
        }

        public void RecordPayment(double amountPaid)
        {
            if (amountPaid > 0)
                Balance += amountPaid;
        }

        public void RecordCall(char callType, int minutes)
        {
            if (callType == 'Г')
                Balance -= minutes * 5;
            else
                if (callType == 'М')
                Balance -= minutes * 1;
        }
        public void RecordCallAfter10Minutes(char callType, int minutes)
        {
            int minTarif = 10;
            if (callType == 'Г')
            {
                if (minutes <= minTarif)
                    Balance -= minutes * priceG;
                else
                    Balance = Balance - (minTarif + (minutes- minTarif) /2)* priceG;
            }
            else
                if (callType == 'М')
                Balance -= minutes * priceM;
        }
        public void RecordCallPayLessUp(char callType, int minutes)
        {
            if (minutes <= 5)
            {
                if (callType == 'Г')
                    Balance -= minutes * priceG/2;
                else
                    if (callType == 'М')
                    Balance -= minutes * priceM/2;
            }
            else
            {
                if (callType == 'Г')
                    Balance -= minutes * priceG*2;
                else
                    if (callType == 'М')
                    Balance -= minutes * priceM*2;
            }
        }

        public void TarifRecordCall(Tarif tarif, char callType, int minutes)
        {
            if (tarif == (Tarif)0)
            {
                RecordCall(callType, minutes);
            }
            else if (tarif == (Tarif)1)
            {
                RecordCallAfter10Minutes(callType, minutes);
            }
            else if (tarif == (Tarif)2)
            {
                RecordCallPayLessUp(callType, minutes);
            }
            else
                Console.WriteLine("Тариф указан неверно");
        }
    }
    public enum Tarif
    {
        Time_based,
        After_10_Minutes_2_Times_Cheaper,
        Pay_LessUp_to_5_Minutes,
    }
    class Customer1
    {
        static void Main(string[] args)
        {
            Customer Ivan = new Customer("Иван Петров", 500);
            Customer Elena = new Customer("Елена Иванова");
            Ivan.RecordCall('Г', 12);
            Elena.RecordCall('М', 25);

            Console.WriteLine(Ivan);
            Console.WriteLine(Elena);

            // тестирование всех возможных вариантов
            // цифра после имени - вариант тарифа
            // g/m после цифры - городской или мобильный
            // b/m в конце имени - больше или меньше условий тарифа

            Customer Ivan0g = new Customer("Иван0g", 500);
            Ivan0g.TarifRecordCall((Tarif)0, 'Г', 10);
            Console.WriteLine(Ivan0g);

            Customer Ivan0m = new Customer("Иван0m", 500);
            Ivan0m.TarifRecordCall((Tarif)0, 'М', 10);
            Console.WriteLine(Ivan0m);

            Customer Ivan1gm = new Customer("Иван1gm", 500);
            Ivan1gm.TarifRecordCall((Tarif)1, 'Г', 10);
            Console.WriteLine(Ivan1gm);

            Customer Ivan1gb = new Customer("Иван1gb", 500);
            Ivan1gb.TarifRecordCall((Tarif)1, 'Г', 20);
            Console.WriteLine(Ivan1gb);

            Customer Ivan1mm = new Customer("Иван1mm", 500);
            Ivan1mm.TarifRecordCall((Tarif)1, 'М', 10);
            Console.WriteLine(Ivan1mm);

            Customer Ivan1mb = new Customer("Иван1mb", 500);
            Ivan1mb.TarifRecordCall((Tarif)1, 'М', 20);
            Console.WriteLine(Ivan1mb);

            Customer Ivan2gm = new Customer("Иван2gm", 500);
            Ivan2gm.TarifRecordCall((Tarif)2, 'Г', 5);
            Console.WriteLine(Ivan2gm);

            Customer Ivan2gb = new Customer("Иван2gb", 500);
            Ivan2gb.TarifRecordCall((Tarif)2, 'Г', 10);
            Console.WriteLine(Ivan2gb);

            Customer Ivan2mm = new Customer("Иван2mm", 500);
            Ivan2mm.TarifRecordCall((Tarif)2, 'М', 5);
            Console.WriteLine(Ivan2mm);

            Customer Ivan2mb = new Customer("Иван2mb", 500);
            Ivan2mb.TarifRecordCall((Tarif)2, 'М', 10);
            Console.WriteLine(Ivan2mb);
        }
    }
}