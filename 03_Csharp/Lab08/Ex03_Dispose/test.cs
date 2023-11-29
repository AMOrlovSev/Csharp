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

            acc1.Deposit(200);
            acc1.Withdraw(100);

            acc2.Deposit(100);
            acc2.Withdraw(200);

            acc3.Deposit(150);
            acc3.Deposit(150);
            acc3.Withdraw(300);

            acc4.Deposit(300);
            acc4.Withdraw(100);
            acc4.Withdraw(200);

            acc1.TransferFrom(acc4, 200);

            using (acc1)
            {
                acc1.Deposit(100);
                acc1.Withdraw(50);
                acc1.Deposit(75);
                acc1.Withdraw(50);
                acc1.Withdraw(30);
                acc1.Deposit(40);
                acc1.Deposit(200);
                acc1.Withdraw(250);
                acc1.Deposit(25);
                Write(acc1);
            }


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
            Console.WriteLine("Transactions:");
            foreach (BankTransaction tran in acc.Transactions())
            {
                Console.WriteLine($"Date/Time: {tran.When()} \t Amount: {tran.Amount()}");
            }
            Console.WriteLine();
        }
    }
}
