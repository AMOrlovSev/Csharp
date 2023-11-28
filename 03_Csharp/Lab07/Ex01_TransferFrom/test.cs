namespace Ex01_TransferFrom
{
    internal class test
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount();

            account1.Populate(100);
            account2.Populate(100);

            Console.WriteLine("Before transfer");
            Console.WriteLine($"{account1.Type()} {account1.Number()} {account1.Balance()}");
            Console.WriteLine($"{account2.Type()} {account2.Number()} {account2.Balance()}");

            account1.TransferFrom(account2, 10);

            Console.WriteLine("After transfer");
            Console.WriteLine($"{account1.Type()} {account1.Number()} {account1.Balance()}");
            Console.WriteLine($"{account2.Type()} {account2.Number()} {account2.Balance()}");
        }
    }
}
