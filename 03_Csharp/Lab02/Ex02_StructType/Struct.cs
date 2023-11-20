using Ex01;

namespace Ex02_StructType
{
    internal class Struct
    {
        static void Main(string[] args)
        {
            BankAccount goldAccount;
            goldAccount.accNo = 0;
            Console.Write("Введите номер счета: ");
            try
            {
                goldAccount.accNo = long.Parse(Console.ReadLine());
                goldAccount.accType = AccountType.Checking;
                goldAccount.accBal = (decimal)3200.00;

                Console.WriteLine($"Acct Number {goldAccount.accNo,11}");
                Console.WriteLine($"Acct Type {goldAccount.accType,13}");
                Console.WriteLine($"Acct Balance {goldAccount.accBal,10}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Неверный ввод: {e.Message}");
            }
        }
    }

    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }


    
}
