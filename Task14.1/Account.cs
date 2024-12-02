namespace HomeTask14._1;

public class Account
{
    private string name;
    private double balance;

    public Account(string name, double initialBalance)
    {
        this.name = name;
        this.balance = initialBalance >= 0 ? initialBalance : 0;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
        else
        {
            Console.WriteLine("You cannot deposit more than ${0}", amount);
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("You cannot withdraw more than ${0}", amount);
            }
        }
        else
        {
            Console.WriteLine("You cannot withdraw less than ${0}", amount);
        }
    }

    public double Balance
    {
        get { return balance; }
    }
}