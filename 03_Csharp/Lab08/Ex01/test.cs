namespace Ex01_TransferFrom
{
    internal class test
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount();
            BankAccount acc2 = new BankAccount(AccountType.Deposit);
            BankAccount acc3 = new BankAccount(100);
            BankAccount acc4 = new BankAccount(AccountType.Deposit, 500);

            Write(acc1);
            Write(acc2);
            Write(acc3);
            Write(acc4);
        }
        static void Write(BankAccount acc)
        {
            Console.WriteLine("Account number is {0}", acc.Number());
            Console.WriteLine("Account balance is {0}", acc.Balance());
            Console.WriteLine("Account type is {0}", acc.Type());
        }
    }
}
