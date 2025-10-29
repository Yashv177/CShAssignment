public class BankAccount
{
    public string AccountNumber { get; set; }
    public string AccountHolderName { get; set; }
    public double Balance { get; private set; }

    public BankAccount(string accountNumber, string accountHolderName, double balance)
    {
        AccountNumber = accountNumber;
        AccountHolderName = accountHolderName;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
            Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
            Balance -= amount;
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account Details:");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Holder Name: {AccountHolderName}");
        Console.WriteLine($"Balance: ${Balance:F2}");
    }
}
