namespace Ex01
{
    internal class Enum
    {
        static void Main(string[] args)
        {
            AccountType goldAccount;
            AccountType platinumAccount;

            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;

            Console.WriteLine($"Аккаунт клиента {goldAccount}");
            Console.WriteLine($"Аккаунт клиента {platinumAccount}");
        }
    }

    public enum AccountType {Checking, Deposit}
}
