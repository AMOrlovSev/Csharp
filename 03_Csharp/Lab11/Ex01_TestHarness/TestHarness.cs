namespace Ex01_TestHarness
{
    internal class TestHarness
    {
        static void Main(string[] args)
        {
            long accNo1 = Bank.CreateAccount(AccountType.Checking, 100);
            long accNo2 = Bank.CreateAccount(AccountType.Checking, 100);
            BankAccount acc1 = Bank.GetAccount(accNo1);
            BankAccount acc2 = Bank.GetAccount(accNo2);
            if (acc1.Equals(acc2))
            {
                Console.WriteLine("Both accounts are the same. They should not be!");
            }
            else
            {
                Console.WriteLine("The accounts are different. Good!");
            }
            if (acc1.Equals(acc2))
            {
                Console.WriteLine("The accounts are different. Good!");
            }
            else
            {
                Console.WriteLine("Both accounts are the same. They should not be!");
            }
            BankAccount acc3 = Bank.GetAccount(accNo1);
            if (!acc1.Equals(acc2))
            {
                Console.WriteLine("The accounts are the same. Good!");
            }
            else
            {
                Console.WriteLine("The accounts are different. They should not be!");
            }
            if (!acc1.Equals(acc2))
            {
                Console.WriteLine("The accounts are different. They should not be!");
            }
            else
            {
                Console.WriteLine("The accounts are the same. Good!");
            }
            Console.WriteLine("acc1 – {0}", acc1);
            Console.WriteLine("acc2 – {0}", acc2);
            Console.WriteLine("acc3 – {0}", acc3);
            acc1.Dispose();
            acc2.Dispose(); 
            acc3.Dispose();
        }
    }
}
