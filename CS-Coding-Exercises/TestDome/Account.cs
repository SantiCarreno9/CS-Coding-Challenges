namespace TestDome;
public class Account
{
    public double Balance { get; private set; }
    public double OverdraftLimit { get; private set; }
    public int Length
    {
        get
        {
            return Length;
        }
    }

    public Account(double overdraftLimit)
    {
        this.OverdraftLimit = overdraftLimit > 0 ? overdraftLimit : 0;
        this.Balance = 0;
    }

    public bool Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            return true;
        }
        return false;
    }

    public bool Withdraw(double amount)
    {
        if (amount > 0 && (OverdraftLimit == 0 && Balance - amount >= 0)
            || (OverdraftLimit > 0 && Balance - amount < OverdraftLimit))
        {
            Balance -= amount;
            return true;
        }
        return false;
    }
}
