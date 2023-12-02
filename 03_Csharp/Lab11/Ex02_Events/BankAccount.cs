using System.Collections;
public delegate void AuditEventHandler(Object sender, AuditEventArgs data);

sealed public class BankAccount : IDisposable
{
    private long accNo;
    private decimal accBal;
    private AccountType accType;
    private static long nextAccNo = 123;
    private Queue tranQueue = new Queue();
    bool disposed = false;
    private Audit accountAudit;
    public void AuditTrail(string auditFileName)
    {
        this.accountAudit = new Audit(auditFileName);
        AuditEventHandler doAuditing = new AuditEventHandler(this.accountAudit.RecordTransaction);
        this.AddOnAuditingTransaction(doAuditing);
    }

    private event AuditEventHandler AuditingTransaction = null;
    public void AddOnAuditingTransaction(AuditEventHandler handler)
    {
        this.AuditingTransaction += handler;
    }
    public void RemoveOnAuditingTransaction(AuditEventHandler handler)
    {
        this.AuditingTransaction -= handler;
    }
    protected void OnAuditingTransaction(BankTransaction bankTrans)
    {
        if (this.AuditingTransaction != null)
        {
            AuditEventArgs auditTrans = new AuditEventArgs(bankTrans);
            this.AuditingTransaction(this, auditTrans);
        }
    }

    public void Dispose()
    {
        if (!disposed)
        {
            accountAudit.Close();
            StreamWriter swFile = File.AppendText("Transactions.Dat");
            swFile.WriteLine("Account number is {0}", accNo);
            swFile.WriteLine("Account balance is {0}", accBal);
            swFile.WriteLine("Account type is {0}", accType);
            swFile.WriteLine("Transactions:");
            foreach (BankTransaction tran in tranQueue)
            {
                swFile.WriteLine("Date/Time: {0}\tAmount:{1}", tran.When(), tran.Amount());
            }
            swFile.Close();
            disposed = true;
            GC.SuppressFinalize(this);
        }
    }

    //public void Populate(decimal balance)
    //{
    //    accNo = NextNumber();
    //    accBal = balance;
    //    accType = AccountType.Checking;
    //}
    internal BankAccount()
    {
        accNo = NextNumber();
        accBal = 0;
        accType = AccountType.Checking;
    }
    internal BankAccount(AccountType aType)
    {
        accNo = NextNumber();
        accType = aType;
        accBal = 0;
    }
    internal BankAccount(decimal aBal)
    {
        accNo = NextNumber();
        accType = AccountType.Checking;
        accBal = aBal;
    }
    internal BankAccount(AccountType aType, decimal aBal)
    {
        accNo = NextNumber();
        accType = aType;
        accBal = aBal;
    }

    public long Number()
    {
        return accNo;
    }

    public decimal Balance()
    {
        return accBal;
    }

    public string Type()
    {
        return accType.ToString();
    }
    private static long NextNumber()
    {
        return nextAccNo++;
    }
    public decimal Deposit(decimal amount)
    {
        accBal += amount;
        BankTransaction tran = new BankTransaction(amount);
        tranQueue.Enqueue(tran);
        this.OnAuditingTransaction(tran);
        return accBal;
    }
    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds)
        {
            accBal -= amount;
            BankTransaction tran = new BankTransaction(-amount);
            tranQueue.Enqueue(tran);
            this.OnAuditingTransaction(tran);
        }
        return sufficientFunds;
    }

    public void TransferFrom(BankAccount accFrom, decimal amount)
    {
        if (accFrom.Withdraw(amount))
            this.Deposit(amount);
    }
    public Queue Transactions()
    {
        return tranQueue;
    }
    ~BankAccount()
    {
        Dispose();
    }
    public static bool operator == (BankAccount acc1, BankAccount acc2)
    {
        if ((acc1.accNo == acc2.accNo) && (acc1.accType == acc2.accType) && (acc1.accBal == acc2.accBal))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool operator != (BankAccount acc1, BankAccount acc2)
    {
        return !(acc1 == acc2);
    }
    public override bool Equals(object acc1)
    {
        return this == (BankAccount)acc1;
    }
    public override string ToString()
    {
        string retVal = "Number: " + this.accNo + "\tType: ";
        retVal += (this.accType == AccountType.Checking) ? "Checking" : "Deposit";
        retVal += "\tBalance: " + this.accBal;
        return retVal;
    }
    public override int GetHashCode()
    {
        return (int)this.accNo;
    }
}