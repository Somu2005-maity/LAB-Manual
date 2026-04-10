using System;

// Base class for all bank accounts
public class BankAccount
{
    // Instance variables
    public string AccountNumber { get; set; }
    public decimal Balance { get; protected set; }

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    // Method to deposit money
    public virtual void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New Balance: {Balance:C}");
        }
    }

    // Virtual method to allow overriding in derived classes
    public virtual void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C}. New Balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds for standard withdrawal.");
        }
    }
}

// Savings Account with InterestRate
public class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    public SavingsAccount(string accountNumber, decimal initialBalance, double interestRate) 
        : base(accountNumber, initialBalance)
    {
        InterestRate = interestRate;
    }

    // Example of adding interest functionality
    public void ApplyInterest()
    {
        decimal interest = Balance * (decimal)(InterestRate / 100);
        Deposit(interest);
        Console.WriteLine($"Interest of {interest:C} applied at {InterestRate}%.");
    }
}

// Current Account with OverdraftLimit
public class CurrentAccount : BankAccount
{
    public decimal OverdraftLimit { get; set; }

    public CurrentAccount(string accountNumber, decimal initialBalance, decimal overdraftLimit) 
        : base(accountNumber, initialBalance)
    {
        OverdraftLimit = overdraftLimit;
    }

    // Method Overriding: Specialized withdrawal for overdraft support
    public override void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= (Balance + OverdraftLimit))
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C} (Overdraft used if balance < 0). New Balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Withdrawal failed: Amount exceeds balance and overdraft limit.");
        }
    }
}
